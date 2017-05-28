using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Creational.Builder
{
    /// <summary>
    /// Director - constructs an object using the Builder interface.
    /// </summary>
    public class Director
    {
        public List<string> structure = new List<string>();
        public Director()
        {

        }

        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
