using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class CreaditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} using Credit Card");
        }
    }
}
