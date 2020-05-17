using System.Collections.Generic;

namespace FactoryMethodPattern.Intefaces
{
    internal interface ICompany
    {
        List<string> PersonelList();
        void TurnOn();
    }
}
