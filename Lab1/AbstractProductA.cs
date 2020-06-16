using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{ 
    public abstract class AbstractProductA
    {
        protected string Nazvanie;
        protected double Massa;
        protected double Skorost;
        protected double Uskorenie;

        public void Print()
        {
            Console.WriteLine("Nazvanie {0} Massa {1} Skorost {2} Uskorenie {3}", Nazvanie, Massa, Skorost, Uskorenie);
        }
    }
}
