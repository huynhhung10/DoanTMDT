using DoanTMDT.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoanTMDT.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task<string> PlaceOrder();

        Task<List<OrderOverviewResponse>> GetOrders();

        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
