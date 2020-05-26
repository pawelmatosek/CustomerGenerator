using ConsoleApp4.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp4.Classes
{
    public class CustomerExternalWriter : IWriteCustomers
    {
        readonly FileStream _fStream;
        readonly BinaryWriter _bWriter;

        public CustomerExternalWriter()
        {
            CheckIfFileExists();
            _fStream = new FileStream(Consts.CustomersFile, FileMode.CreateNew);
            _bWriter = new BinaryWriter(_fStream);
        }

        public void WriteCustomers(List<Customer> customers)
        {
            foreach(var customer in customers)
            {
                WritePair(Type.SurName, customer.SurName);
                WritePair(Type.Name, customer.Name);
                WritePair(Type.Age, customer.Age.ToString());
                WritePair(Type.Address, customer.Address);
            }            
        }

        private void WritePair(Type type, string value)
        {
            BinaryWriter(type.ToString());
            BinaryWriter(value);
        }

        private void BinaryWriter(string value)
        {
            foreach(var v in value)
                _bWriter.Write(Convert.ToChar(v));
            _bWriter.Write(' ');
        }

        private void CheckIfFileExists()
        {
            if (File.Exists(Consts.CustomersFile))
            {
                Console.WriteLine($"{Consts.CustomersFile} already exists!");
                return;
            }
        }
    }
}
