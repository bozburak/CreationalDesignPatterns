using FactoryMethodPattern.Intefaces;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern.Companys
{
    internal class Company1 : ICompany
    {
        public List<string> PersonelList()
        {
            return new List<string>() { "Company1Personel1", "Company1Personel2", "Company1Personel3" };
        }

        public void TurnOn()
        {
            Console.WriteLine("Company1 Person List");
        }
    }
}
