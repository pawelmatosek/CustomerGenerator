using ConsoleApp4.Interfaces;
using System.Collections.Generic;

namespace ConsoleApp4.Classes
{
    public class CustomerGenerator : IGetCustomersList
    {
        readonly Randomizer _randomizer;
        readonly List<Customer> _customers;

        public CustomerGenerator()
        {
            _randomizer = new Randomizer();
            _customers = new List<Customer>();
        }

        public List<Customer> GetCustomersList(int customersNumber)
        {
            for (int i = 0; i < customersNumber; i++)
                _customers.Add(_randomizer.GetRandomCustomer());
            return _customers;
        }
    }
}
