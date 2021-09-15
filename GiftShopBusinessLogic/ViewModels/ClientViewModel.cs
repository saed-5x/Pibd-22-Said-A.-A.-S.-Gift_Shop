using System.ComponentModel;
using System.Runtime.Serialization;
using GiftShopBusinessLogic.Attributes;

namespace GiftShopBusinessLogic.ViewModels
{
    [DataContract]
    public class ClientViewModel
    {
        [DataMember]
        [Column(title: "Number", width: 100, visible: false)]
        public int Id { get; set; }

        [DataMember]
        [Column(title: "Client name", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ClientFIO { get; set; }

        [DataMember]
        [Column(title: "Login", width: 150)]
        public string Email { get; set; }

        [DataMember]
        [Column(title: "Password", width: 150)]
        public string Password { get; set; }
    }
}
