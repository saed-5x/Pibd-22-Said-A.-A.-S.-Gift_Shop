﻿namespace GiftShopBusinessLogic.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int GiftId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }
    }
}
