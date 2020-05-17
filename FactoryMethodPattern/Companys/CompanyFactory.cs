using FactoryMethodPattern.Enum;
using FactoryMethodPattern.Intefaces;

namespace FactoryMethodPattern.Companys
{
    internal class CompanyFactory
    {
        internal static ICompany GetCompany(Company company)
        {
            switch (company)
            {
                case Company.Company1: return new Company1();
                case Company.Company2: return new Company2();
                case Company.Company3: return new Company3();
                default: return new Company1();
            }
        }
    }
}
