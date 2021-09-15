using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace GiftShopBusinessLogic.ViewModels
{
    [DataContract]
    public class GiftViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("Product name")]

        public string GiftName { get; set; }

        [DataMember]
        [DisplayName("Price")]

        public decimal Price { get; set; }

        [DataMember]
        public Dictionary<int, (string, int)> GiftComponents { get; set; }
    }
}
