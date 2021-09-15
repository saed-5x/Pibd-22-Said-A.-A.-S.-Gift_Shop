using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using GiftShopBusinessLogic.Attributes;

namespace GiftShopBusinessLogic.ViewModels
{
    [DataContract]
    public class MessageInfoViewModel
    {
        [DataMember]
        [Column(title: "Number", width: 100, visible: false)]
        public string MessageId { get; set; }

        [DataMember]
        [Column(title: "Sender", width: 150)]
        public string SenderName { get; set; }

        [DataMember]
        [Column(title: "Date of letter", width: 100)]
        public DateTime DateDelivery { get; set; }

        [DataMember]
        [Column(title: "Heading", width: 150)]
        public string Subject { get; set; }

        [DataMember]
        [Column(title: "Text", gridViewAutoSize: GridViewAutoSize.AllCells)]
        public string Body { get; set; }
    }
}