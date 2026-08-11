using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public static class PaymentFactory
    {
        public static IPayment CreatePayment(PaymenType paymenType)
        {

            switch (paymenType)
            {
                case PaymenType.Bkash:
                    return new BkashPayment();
                case PaymenType.Paypal:
                    return new PayPalPayment();

                case PaymenType.Creditcard:
                    return new CreaditCardPayment();

                case PaymenType.Rocket:
                    return new RocketPayment();

                default:
                    throw new ArgumentException("Unsupported payment type");
            }
        }
    }
}

