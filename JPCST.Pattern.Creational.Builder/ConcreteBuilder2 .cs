﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Creational.Builder
{
    /// <summary>
    /// ConcreteBuilder - constructs and assembles parts of the product by implementing the Builder interface.
    /// ConcreteBuilder - defines and keeps track of the representation it creates.
    /// ConcreteBuilder - provides an interface for retrieving the product.
    /// </summary>
    public class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }
}
