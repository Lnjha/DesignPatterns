namespace ObserverPattern.Participants
{
    public class Investor : IInvestor
    {
        private string _name;
        public Investor(string name)
        {
            _name=name;
        }
        public void Update(Stock stock)
        {
            System.Console.WriteLine($"{_name} notified for price change of {stock.Symbol} to {stock.Price}");
        }
    }
}