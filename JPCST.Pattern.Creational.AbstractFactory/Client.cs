using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Creational.AbstractFactory
{
    /// <summary>
    /// Client - uses interfaces declared by AbstractFactory and AbstractProduct classes.
    /// </summary>
    public class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
