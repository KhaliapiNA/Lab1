using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   abstract class AbstractFactory
    {
       //Поступательное движение
         public abstract AbstractProductA CreateProductA(); //напиток
       //Вращательное движение
         public abstract AbstractProductB CreateProductB(); //бутылка

    } 
}

