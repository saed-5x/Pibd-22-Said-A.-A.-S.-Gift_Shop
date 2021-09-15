using System;
using System.Collections.Generic;
using System.Text;
using GiftShopBusinessLogic.Enums;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace GiftShopBusinessLogic.ViewModels
{
    [DataContract]
    public class OrderViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public int? ImplementerId { get; set; }

        [DataMember]
        public int GiftId { get; set; }

        [DataMember]
        [DisplayName("Client")]
        public string ClientFIO { get; set; }

        [DataMember]
        [DisplayName("Artist")]
        public string ImplementerFIO { get; set; }

        [DataMember]
        [DisplayName("Product")]
        public string GiftName { get; set; }

        [DataMember]
        [DisplayName("Quantity")]
        public int Count { get; set; }

        [DataMember]
        [DisplayName("Sum")]
        public decimal Sum { get; set; }

        [DataMember]
        [DisplayName("Status")]
        public OrderStatus Status { get; set; }

        [DataMember]
        [DisplayName("Date Create")]
        public DateTime DateCreate { get; set; }

        [DataMember]
        [DisplayName("Date Implement")]
        public DateTime? DateImplement { get; set; }
    }
}