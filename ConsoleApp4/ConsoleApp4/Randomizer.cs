using ConsoleApp4.Classes;
using System;
using System.Text;

namespace ConsoleApp4
{
    public class Randomizer
    {
        private Customer _customer;
        private Random _rd;
        private StringBuilder _sb;

        public Randomizer()
        {
            _rd = new Random();
            _sb = new StringBuilder();
        }

        public Customer GetRandomCustomer()
        {
            _customer = new Customer
            {
                SurName = GetRandomString(),
                Name = GetRandomString(),
                Age = GetRandomAge(),
                Address = GetRandomString()
            };
            return _customer;
        }

        public string GetRandomString()
        {
            for(int i = 0; i < GetRandomLength(); i++)
                _sb.Append(GetRandomChar());
            return _sb.ToString();
        }

        private int GetNext(int max, int min = Consts.MinimalRandomNumber) => _rd.Next(min, max);

        private int GetRandomAge() => GetNext(max: Consts.MaxHumanAge);

        private int GetRandomLength() => GetNext(max: Consts.MaxRandomLegth);

        private char GetRandomChar() => Convert.ToChar(GetNext(max: Consts.LettersInAlphabet) + Consts.SkipToAsciiValues);
    }
}
