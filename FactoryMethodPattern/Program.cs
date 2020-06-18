using System;
using FactoryMethodPattern.Participants;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var permanentEmployee=EmployeeInstanceCreator.CreateEmployeeInstance("permanent");
            permanentEmployee.SetPolicy();

            var temproryEmployee=EmployeeInstanceCreator.CreateEmployeeInstance("contract");
            temproryEmployee.SetPolicy();
        }
    }
}
