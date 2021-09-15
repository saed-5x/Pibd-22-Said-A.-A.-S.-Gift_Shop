using System;
using System.Collections.Generic;
using System.Text;
using GiftShopBusinessLogic.Enums;
using GiftShopBusinessLogic.BindingModels;
using GiftShopBusinessLogic.Interfaces;
using GiftShopBusinessLogic.ViewModels;

namespace GiftShopBusinessLogic.BusinessLogic
{
    public class OrderLogic
    {
        private readonly IOrderStorage _orderStorage;

        private readonly object locker = new object();

        public OrderLogic(IOrderStorage orderStorage)
        {
            _orderStorage = orderStorage;
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            if (model == null)
            {
                return _orderStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<OrderViewModel> { _orderStorage.GetElement(model) };
            }
            return _orderStorage.GetFilteredList(model);
        }

        public void CreateOrder(CreateOrderBindingModel model)
        {
            _orderStorage.Insert(new OrderBindingModel
            {
                GiftId = model.GiftId,
                Count = model.Count,
                Sum = model.Sum,
                DateCreate = DateTime.Now,
                Status = OrderStatus.Accepted,
                ClientId = model.ClientId
            });
        }

        public void TakeOrderInWork(ChangeStatusBindingModel model)
        {
            lock (locker)
            {

                var order = _orderStorage.GetElement(new OrderBindingModel { Id = model.OrderId });
                if (order == null)
                {
                    throw new Exception("Order not found");
                }
                if (order.Status != OrderStatus.Accepted)
                {
                    throw new Exception("The order is not in the status \"Accepted\"");
                }
                if (order.ImplementerId.HasValue)
                {
                    throw new Exception("The order already has a artist");
                }
                _orderStorage.Update(new OrderBindingModel
                {
                    Id = order.Id,
                    ClientId = order.ClientId,
                    ImplementerId = model.ImplementerId,
                    GiftId = order.GiftId,
                    Count = order.Count,
                    Sum = order.Sum,
                    DateCreate = order.DateCreate,
                    DateImplement = DateTime.Now,
                    Status = OrderStatus.Performed
                });
            }
        }

        public void FinishOrder(ChangeStatusBindingModel model)
        {
            var order = _orderStorage.GetElement(new OrderBindingModel { Id = model.OrderId });
            if (order == null)
            {
                throw new Exception("Order not found");
            }
            if (order.Status != OrderStatus.Performed)
            {
                throw new Exception("The order is not in the status \"Performed\"");
            }
            _orderStorage.Update(new OrderBindingModel
            {
                Id = order.Id,
                GiftId = order.GiftId,
                Count = order.Count,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement,
                Status = OrderStatus.Ready,
                ClientId = order.ClientId,
                ImplementerId = order.ImplementerId
            });
        }

        public void PayOrder(ChangeStatusBindingModel model)
        {
            var order = _orderStorage.GetElement(new OrderBindingModel { Id = model.OrderId });
            if (order == null)
            {
                throw new Exception("Order not found");
            }
            if (order.Status != OrderStatus.Ready)
            {
                throw new Exception("The order is not in the status \"Ready\"");
            }
            _orderStorage.Update(new OrderBindingModel 
            {
                Id = order.Id,
                GiftId = order.GiftId,
                Count = order.Count,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement,
                Status = OrderStatus.Paid,
                ClientId = order.ClientId
            });
        }
    }
}
