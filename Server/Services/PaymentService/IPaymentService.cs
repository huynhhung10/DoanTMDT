using Stripe.Checkout;
using DoanTMDT.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DoanTMDT.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Task<Session> CreateCheckoutSession();

        Task<ServiceResponse<bool>> FulfillOrder(HttpRequest request);
    }
}
