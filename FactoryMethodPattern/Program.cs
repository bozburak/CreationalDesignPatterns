using FactoryMethodPattern.Companys;
using FactoryMethodPattern.Enum;
using FactoryMethodPattern.Intefaces;
using System;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICompany company1 = CompanyFactory.GetCompany(Company.Company1);
            company1.TurnOn();
            var company1PersonelList = company1.PersonelList();
            company1PersonelList.ForEach(i => Console.Write($"{Environment.NewLine}{i}"));
            Console.WriteLine(Environment.NewLine);


            ICompany company2 = CompanyFactory.GetCompany(Company.Company2);
            company2.TurnOn();
            var company2PersonelList = company2.PersonelList();
            company2PersonelList.ForEach(i => Console.Write($"{Environment.NewLine}{i}"));
            Console.WriteLine(Environment.NewLine);

            ICompany company3 = CompanyFactory.GetCompany(Company.Company3);
            company3.TurnOn();
            var company3PersonelList = company3.PersonelList();
            company3PersonelList.ForEach(i => Console.Write($"{Environment.NewLine}{i}"));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
