using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //А1 = Квадрат
    //Поступательное движение
    public class ProductA1 : AbstractProductA
    {
        public ProductA1(string n, double m, double s, double u)
        {
            Nazvanie = n;
            Massa = m;
            Skorost = s;
            Uskorenie = u;
        }
    }
}
