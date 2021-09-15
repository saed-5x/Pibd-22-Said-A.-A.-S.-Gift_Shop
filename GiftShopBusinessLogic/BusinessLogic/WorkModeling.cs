using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GiftShopBusinessLogic.BindingModels;
using GiftShopBusinessLogic.Interfaces;
using GiftShopBusinessLogic.ViewModels;

namespace GiftShopBusinessLogic.BusinessLogic
{
    public class WorkModeling
    {
        private readonly IImplementerStorage _implementerStorage;

        private readonly IOrderStorage _orderStorage;

        private readonly OrderLogic _orderLogic;

        private readonly Random rnd;

        public WorkModeling(IImplementerStorage implementerStorage, IOrderStorage orderStorage, OrderLogic orderLogic)
        {
            this._implementerStorage = implementerStorage;
            this._orderStorage = orderStorage;
            this._orderLogic = orderLogic;
            rnd = new Random(1000);
        }

        public void DoWork()
        {
            var implementers = _implementerStorage.GetFullList();
            var orders = _orderStorage.GetFilteredList(new OrderBindingModel { FreeOrders = true });
            foreach (var implementer in implementers)
            {
                WorkerWorkAsync(implementer, orders);
            }
        }

        private async void WorkerWorkAsync(ImplementerViewModel implementer, List<OrderViewModel> orders)
        {
            // looking for orders that are already in work (suddenly the executor was interrupted)
            var runOrders = await Task.Run(() => _orderStorage.GetFilteredList(new OrderBindingModel { ImplementerId = implementer.Id }));
            foreach (var order in runOrders)
            {
                // do the job again
                Thread.Sleep(implementer.WorkingTime * rnd.Next(1, 5) * order.Count);
                _orderLogic.FinishOrder(new ChangeStatusBindingModel { OrderId = order.Id, ImplementerId = implementer.Id });
                // wait
                Thread.Sleep(implementer.PauseTime);
            }
            await Task.Run(() =>
            {
                foreach (var order in orders)
                {
                    // trying to assign an order to the artist
                    try
                    {
                        _orderLogic.TakeOrderInWork(new ChangeStatusBindingModel { OrderId = order.Id, ImplementerId = implementer.Id });
                        // do the work
                        Thread.Sleep(implementer.WorkingTime * rnd.Next(1, 5) * order.Count);
                        _orderLogic.FinishOrder(new ChangeStatusBindingModel { OrderId = order.Id, ImplementerId = implementer.Id });
                        // wait
                        Thread.Sleep(implementer.PauseTime);
                    }
                    catch (Exception) { }
                }
            });
        }
    }
}
