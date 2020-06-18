namespace TemplatePattern.Participants
{
    public class ProductDataAccess : AbstractDataAccess
    {
        public override void Process()
        {
            System.Console.WriteLine("Process product data");
        }

        public override void Select()
        {
            System.Console.WriteLine("Select product data.");
        }
    }
}