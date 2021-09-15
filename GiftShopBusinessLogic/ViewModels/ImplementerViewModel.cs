using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using GiftShopBusinessLogic.Attributes;

namespace GiftShopBusinessLogic.ViewModels
{
    public class ImplementerViewModel
    {
        [Column(title: "Number", width: 100, visible: false)]
        public int Id { get; set; }

        [Column(title: "Full name of the artist", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ImplementerFIO { get; set; }

        [Column(title: "Time to order", width: 100)]
        public int WorkingTime { get; set; }

        [Column(title: "Time to order", width: 100)]
        public int PauseTime { get; set; }
    }
}
