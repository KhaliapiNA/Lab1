using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //A2 - Круг
    //Поступательное движение
    public class ProductA2 : AbstractProductA
    {
        public ProductA2(string n, double m, double s, double u)
        {
            Nazvanie = n;
            Massa = m;
            Skorost = s;
            Uskorenie = u;
        }
    }
}
