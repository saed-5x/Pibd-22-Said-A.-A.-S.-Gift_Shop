using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Xml.Serialization;

namespace GiftShopBusinessLogic.BusinessLogic
{
    public abstract class BackUpAbstractLogic
    {
        public void CreateArchive(string folderName)
        {
            try
            {
                folderName += "\\GiftShopBackUp";
                DirectoryInfo dirInfo = new DirectoryInfo(folderName);
                if (dirInfo.Exists)
                {
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }
                else
                {
                    Directory.CreateDirectory(folderName);
                }
                string fileName = $"{folderName}.zip";
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                // take an assembly to create objects from it
                Assembly assem = GetAssembly();
                // pull out the list of classes to save
                var dbsets = GetFullList();
                // take the method to save (from the base abstract class)
                MethodInfo method = GetType().BaseType.GetTypeInfo().GetDeclaredMethod("SaveToFile");
                foreach (var set in dbsets)
                {
                    // create an object from the class to save
                    var elem = assem.CreateInstance(set.PropertyType.GenericTypeArguments[0].FullName);
                    // generate a method based on the class
                    MethodInfo generic = method.MakeGenericMethod(elem.GetType());
                    // call the method for execution
                    generic.Invoke(this, new object[] { folderName });
                }
                // archive
                ZipFile.CreateFromDirectory(folderName, fileName);
                // delete the folder
                dirInfo.Delete(true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SaveToFile<T>(string folderName) where T : class, new()
        {
            var records = GetList<T>();
            T obj = new T();
            XmlSerializer serialiser = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(string.Format("{0}/{1}.xml", folderName, obj.GetType().Name), FileMode.OpenOrCreate))
            {
                serialiser.Serialize(fs, records);
            }

        }

        protected abstract Assembly GetAssembly();

        protected abstract List<PropertyInfo> GetFullList();

        protected abstract List<T> GetList<T>() where T : class, new();
    }
}