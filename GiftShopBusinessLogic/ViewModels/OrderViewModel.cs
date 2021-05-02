using System;
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
        [DisplayName("Number")]

        public int Count { get; set; }
        [DisplayName("Amount")]

        public decimal Sum { get; set; }
        [DisplayName("Status")]

        public OrderStatus Status { get; set; }
        [DisplayName("Date of creation")]

        public DateTime DateCreate { get; set; }
        [DisplayName("Date of completion")]

        public DateTime? DateImplement { get; set; }
    }
}
