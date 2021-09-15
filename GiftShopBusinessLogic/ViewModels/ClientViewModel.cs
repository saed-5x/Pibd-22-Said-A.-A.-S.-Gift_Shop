using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace GiftShopBusinessLogic.ViewModels
{
    [DataContract]
    public class ClientViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("Client name")]
        public string ClientFIO { get; set; }

        [DataMember]
        [DisplayName("Login")]
        public string Email { get; set; }

        [DataMember]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
