using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ProductB2 : AbstractProductB
    {
        //В2 = Круг
        //Вращательное движение
        public ProductB2(string n, double m, double ugl_s, double ugl_u)
        {
            Nazvanie = n;
            Massa = m;
            Ugl_Skorost = ugl_s;
            Ugl_Uskorenie = ugl_u;
        }
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this + " взаимодействует с " + a);
        }
    }
}
