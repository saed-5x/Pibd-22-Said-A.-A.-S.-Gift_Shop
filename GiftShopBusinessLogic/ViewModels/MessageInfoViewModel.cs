using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace GiftShopBusinessLogic.ViewModels
{
    [DataContract]
    public class MessageInfoViewModel
    {
        [DataMember]
        public string MessageId { get; set; }

        [DisplayName("Sender")]
        [DataMember]
        public string SenderName { get; set; }

        [DisplayName("Date of letter")]
        [DataMember]
        public DateTime DateDelivery { get; set; }

        [DisplayName("Heading")]
        [DataMember]
        public string Subject { get; set; }

        [DisplayName("Text")]
        [DataMember]
        public string Body { get; set; }
    }
}