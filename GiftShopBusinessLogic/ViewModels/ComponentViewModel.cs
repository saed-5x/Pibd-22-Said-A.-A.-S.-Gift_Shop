﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using GiftShopBusinessLogic.Attributes;

namespace GiftShopBusinessLogic.ViewModels
{
    public class ComponentViewModel
    {
        [Column(title: "Number", width: 100, visible: false)]
        public int Id { get; set; }

        [Column(title: "Component name", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }
    }
}
