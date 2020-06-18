using System;

namespace TemplatePattern.Participants
{
    public abstract class AbstractDataAccess
    {
        //Template Method
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }

        public virtual void Connect()
        {
            //Db Connection logic
            Console.WriteLine("Connect to Database");
        }

        public abstract void Select();

        public abstract void Process();
        public virtual void Disconnect()
        {
            Console.WriteLine("Disconnect from Databse");
        }
    }
}