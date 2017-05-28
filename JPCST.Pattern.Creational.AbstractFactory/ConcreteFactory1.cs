using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Creational.AbstractFactory
{
    /// <summary>
    /// ConcreteFactory - implements the operations to create concrete product objects.
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        public ConcreteFactory1()
        {

        }

        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
