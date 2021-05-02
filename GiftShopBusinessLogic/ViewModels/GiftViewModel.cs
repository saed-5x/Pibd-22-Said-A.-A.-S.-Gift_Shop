using System.Collections.Generic;
using System.ComponentModel;

namespace GiftShopBusinessLogic.ViewModels
{
    public class GiftViewModel
    {
        public int Id { get; set; }
        [DisplayName("Product name")]

        public string GiftName { get; set; }
        [DisplayName("Price")]

        public decimal Price { get; set; }

        public Dictionary<int, (string, int)> GiftComponents { get; set; }
    }
}
