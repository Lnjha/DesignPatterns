namespace ObserverPatternUsingEvents.Participants
{
    public delegate void StockSubscriber(string name);
    public abstract class Stock
    {
        public event StockSubscriber StockPriceChange;
        
    }
}