using System;
using TemplatePattern.Participants;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerData=new CustomerDataAccess();
            customerData.Run();

            var productData=new ProductDataAccess();
            productData.Run();
        }
    }
}
