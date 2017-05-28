using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Creational.AbstractFactory
{
    /// <summary>
    /// AbstractFactory - declares an interface for operations that create abstract products.
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }
}
