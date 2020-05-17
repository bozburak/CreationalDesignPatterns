using FactoryMethodPattern.Intefaces;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern.Companys
{
    internal class Company2 : ICompany
    {
        public List<string> PersonelList()
        {
            return new List<string>() { "Company2Personel1", "Company2Personel2", "Company2Personel3" };
        }

        public void TurnOn()
        {
            Console.WriteLine("Company2 Person List");
        }
    }
}
