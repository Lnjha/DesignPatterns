using System;
using ObserverPattern.Participants;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBMStock iBMStock=new IBMStock("IBM",100);
            iBMStock.Attach(new Investor("Ram"));
            iBMStock.Attach(new Investor("Shyam"));
            iBMStock.Price=200;
            iBMStock.Price=300.20;
        }
    }
}
