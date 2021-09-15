using System;
using System.Collections.Generic;
using System.Text;
using GiftShopBusinessLogic.Enums;
using System.ComponentModel;

namespace GiftShopBusinessLogic.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public int GiftId { get; set; }
        [DisplayName("Product")]

        public string GiftName { get; set; }
        [DisplayName("Quantity")]

        public int Count { get; set; }
        [DisplayName("Sum")]

        public decimal Sum { get; set; }
        [DisplayName("Status")]

        public OrderStatus Status { get; set; }
        [DisplayName("Date Create")]

        public DateTime DateCreate { get; set; }
        [DisplayName("Date Implement")]

        public DateTime? DateImplement { get; set; }
    }
}
