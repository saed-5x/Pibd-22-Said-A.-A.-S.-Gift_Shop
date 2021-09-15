using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using GiftShopBusinessLogic.Attributes;

namespace GiftShopBusinessLogic.ViewModels
{
    [DataContract]
    public class GiftViewModel
    {
        [DataMember]
        [Column(title: "Number", width: 100, visible: false)]
        public int Id { get; set; }

        [DataMember]
        [Column(title: "Product name", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string GiftName { get; set; }

        [DataMember]
        [Column(title: "Price", width: 100)]
        public decimal Price { get; set; }

        [DataMember]
        public Dictionary<int, (string, int)> GiftComponents { get; set; }
    }
}
