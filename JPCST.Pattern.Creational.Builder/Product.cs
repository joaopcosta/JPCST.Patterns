using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Creational.Builder
{
    /// <summary>
    /// Product - represents the complex object under construction.
    /// Product - ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled.
    /// Product - includes classes that define the constituent parts, including interfaces for assembling the parts into the final result.
    /// </summary>
    public class Product
    {
        private List<string> _parts = new List<string>();
        public Product()
        {

        }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
