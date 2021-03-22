using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Optimistic : IObserver
    {
        public void Update(IObservable stock)
        {
            if((stock as Stock).State == false)
            {
                Console.WriteLine("Optimistic Seller won't sell their Stock as price is falling");
            }
            else Console.WriteLine("Optimistic Seller can sell their Stock as price isn't falling");

        }
    }
}
