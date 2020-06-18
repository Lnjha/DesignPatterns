using System.Collections.Generic;
namespace ObserverPattern.Participants
{
    public class Stock
    {
        private double _price;
        public string Symbol { get; set; }

        public Stock(string symbol,double price)
        {
            Symbol=symbol;
            _price=price;
        }
        private List<IInvestor> _investors = new List<IInvestor>();
        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }
        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
        }

        public double Price { get{
            return _price;
        } set{
            if(value!=_price)
            {
                _price=value;
                Notify();
            }
        } }
    }
}