using System;
using System.Collections.Generic;
using System.Text;
using GiftShopBusinessLogic.Enums;
using System.ComponentModel;
using System.Runtime.Serialization;
using GiftShopBusinessLogic.Attributes;

namespace GiftShopBusinessLogic.ViewModels
{
    [DataContract]
    public class OrderViewModel
    {
        [DataMember]
        [Column(title: "Number", width: 100, visible: false)]
        public int Id { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public int? ImplementerId { get; set; }

        [DataMember]
        public int GiftId { get; set; }

        [DataMember]
        [Column(title: "Client", width: 150)]
        public string ClientFIO { get; set; }

        [DataMember]
        [Column(title: "Artist", width: 150)]
        public string ImplementerFIO { get; set; }

        [DataMember]
        [Column(title: "Product", width: 150)]
        public string GiftName { get; set; }

        [DataMember]
        [Column(title: "Quantity", width: 100)]
        public int Count { get; set; }

        [DataMember]
        [Column(title: "Sum", width: 50)]
        public decimal Sum { get; set; }

        [DataMember]
        [Column(title: "Status", width: 100)]
        public OrderStatus Status { get; set; }

        [DataMember]
        [Column(title: "Date Create", width: 100)]
        public DateTime DateCreate { get; set; }

        [DataMember]
        [Column(title: "Date Implement", width: 100)]
        public DateTime? DateImplement { get; set; }
    }
}