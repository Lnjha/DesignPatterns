namespace FactoryMethodPattern.Participants
{
    public class PermanentEmployee : Employee
    {
        public override void SetPolicy()
        {
            System.Console.WriteLine("Set policy for permanent employee");
        }
    }
}