namespace SingletonPattern.Participants
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance=new Singleton();
        private Singleton()
        {
            
        }
        static Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            return _instance;
        }
    }
}