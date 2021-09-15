using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace GiftShopBusinessLogic.ViewModels
{
    public class ImplementerViewModel
    {
        public int Id { get; set; }

        [DisplayName("Full name of the artist")]
        public string ImplementerFIO { get; set; }

        [DisplayName("Time to order")]
        public int WorkingTime { get; set; }

        [DisplayName("Time to order")]
        public int PauseTime { get; set; }
    }
}
