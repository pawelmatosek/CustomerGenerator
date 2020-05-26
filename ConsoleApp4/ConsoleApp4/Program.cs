using ConsoleApp4.Classes;

namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] args)
        {
            CustomerGenerator customerGenerator = new CustomerGenerator();
            CustomerExternalWriter externalWriter = new CustomerExternalWriter();

            var Clients = customerGenerator.GetCustomersList(Consts.RandomCustomers);
            externalWriter.WriteCustomers(Clients);
        }
    }
}
