using System.Collections.Generic;
using GiftShopBusinessLogic.ViewModels;

namespace GiftShopBusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportGiftComponentViewModel> ComponentGifts { get; set; }
    }
}
