using ConsoleApp4.Classes;
using System.Collections.Generic;

namespace ConsoleApp4.Interfaces
{
    public interface IGetCustomersList
    {
        List<Customer> GetCustomersList(int customersNumber);
    }
}
