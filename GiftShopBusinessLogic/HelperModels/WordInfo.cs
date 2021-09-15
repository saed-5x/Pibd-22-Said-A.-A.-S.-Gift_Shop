using System.Collections.Generic;
using GiftShopBusinessLogic.ViewModels;

namespace GiftShopBusinessLogic.HelperModels
{
    class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<GiftViewModel> Gifts { get; set; }
    }
}
