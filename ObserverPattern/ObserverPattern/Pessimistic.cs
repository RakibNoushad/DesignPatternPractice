using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Pessimistic : IObserver
    {
        public void Update(IObservable stock)
        {
            if ((stock as Stock).State == false)
            {
                Console.WriteLine("Pessimistic Seller can sell their Stock but price is falling");
            }
            else Console.WriteLine("Pessimistic Seller can sell their Stock but price isn't falling");

        }
    }
}
