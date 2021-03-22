using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Stock : IObservable
    {
        public bool State { get; set; } = false;
        private int currPrice;
        public int prevPrice;

        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }
        public void Notify()
        {
            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void getCurrPrice()
        {
            Console.WriteLine("Enter Current Price of Stock");
            currPrice = Int32.Parse(Console.ReadLine());

            if(currPrice!= prevPrice)
            {
                State = currPrice>=prevPrice;
                this.Notify();
                prevPrice = currPrice;
            }
        }


        
    }
}
