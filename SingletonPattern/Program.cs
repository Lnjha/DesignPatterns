using System;
using SingletonPattern.Participants;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance=Singleton.GetInstance();
        }
    }
}
