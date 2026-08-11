using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class OrderService : IOrderCheckoutService
    {
        public void Checkout(PaymenType paymentType, decimal amount)
        {
           IPayment payment = PaymentFactory.CreatePayment(paymentType);

            payment.Pay(amount);
        }
    }
}
