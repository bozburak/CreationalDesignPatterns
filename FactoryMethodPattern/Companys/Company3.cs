using FactoryMethodPattern.Intefaces;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern.Companys
{
    class Company3 : ICompany
    {
        public List<string> PersonelList()
        {
            return new List<string>() { "Company3Personel1", "Company3Personel2", "Company3Personel3" };
        }

        public void TurnOn()
        {
            Console.WriteLine("Company3 Person List");
        }
    }
}
