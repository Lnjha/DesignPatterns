namespace FactoryMethodPattern.Participants
{
    public class TemproryEmployee : Employee
    {
        public override void SetPolicy()
        {
            System.Console.WriteLine("Set policy for contractual employee");
        }
    }
}