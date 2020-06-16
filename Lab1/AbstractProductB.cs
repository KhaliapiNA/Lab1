using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class AbstractProductB
    {
        protected string Nazvanie;
        protected double Massa;
        protected double Ugl_Skorost;
        protected double Ugl_Uskorenie;

        public void Print()
        {
            Console.WriteLine("Nazvanie {0} Massa {1} Ugl_skorost {2} Ugl_Uskorenie {3}", Nazvanie, Massa, Ugl_Skorost, Ugl_Uskorenie);
        }
        public abstract void Interact(AbstractProductA a);
    }
}
