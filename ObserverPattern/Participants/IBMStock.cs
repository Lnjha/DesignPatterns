namespace ObserverPattern.Participants
{
    public class IBMStock : Stock
    {
        public IBMStock(string symbol, double price) : base(symbol, price)
        {
        }
    }
}