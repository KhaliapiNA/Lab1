using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ConcreteFactory2 : AbstractFactory
    {
        //2 - Круг
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2("A2", 5, 10, 2); //напиток Coca-Cola
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2("B2", 5, 12, 6); //бутылка для Coca-Cola
        }
    }
}
