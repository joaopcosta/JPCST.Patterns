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
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
