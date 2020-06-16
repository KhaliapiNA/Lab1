using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ConcreteFactory1 : AbstractFactory
    { 
        //1 - Квадрат
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1("A1", 6, 9, 12); //напиток Pepsi
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1("B1", 6, 14, 7); //бутылка для Pepsi
        }
    }
}
