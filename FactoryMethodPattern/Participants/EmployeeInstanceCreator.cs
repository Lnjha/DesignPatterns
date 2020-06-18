using System;
namespace FactoryMethodPattern.Participants
{
    public class EmployeeInstanceCreator
    {
        public static Employee CreateEmployeeInstance(string type)
        {
            switch(type.ToLower())
            {
                case "permanent":
                return new PermanentEmployee();
                case "contract":
                return new TemproryEmployee();
                default:
                throw new ArgumentException($"Employee of type {type} doesn't exist.");
            }
        }
    }
}