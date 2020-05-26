using ConsoleApp4.Classes;
using System;
using System.Text;

namespace ConsoleApp4
{
    public class Randomizer
    {
        Customer customer;
        Random random;
        StringBuilder builder;

        public Randomizer()
        {
            random = new Random();
            builder = new StringBuilder();
        }

        public Customer GetRandomCustomer()
        {
            customer = new Customer
            {
                SurName = GetRandomString(),
                Name = GetRandomString(),
                Age = GetRandomAge(),
                Address = GetRandomString()
            };
            return customer;
        }

        public string GetRandomString()
        {
            for(int i = 0; i < GetRandomLength(); i++)
                builder.Append(GetRandomChar());
            return builder.ToString();
        }

        private int GetNext(int max, int min = Consts.MinimalRandomNumber) => random.Next(min, max);

        private int GetRandomAge() => GetNext(max: Consts.MaxHumanAge);

        private int GetRandomLength() => GetNext(max: Consts.MaxRandomLegth);

        private char GetRandomChar() => Convert.ToChar(GetNext(max: Consts.LettersInAlphabet) + Consts.SkipToAsciiValues);
    }
}
