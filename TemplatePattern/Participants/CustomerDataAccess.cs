namespace TemplatePattern.Participants
{
    public class CustomerDataAccess : AbstractDataAccess
    {
        public override void Process()
        {
            System.Console.WriteLine("Process customer data.");
        }

        public override void Select()
        {
           System.Console.WriteLine("Select customer data.");
        }
    }
}