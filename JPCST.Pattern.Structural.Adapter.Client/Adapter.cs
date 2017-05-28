using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Structural.Adapter
{
    /// <summary>
    /// Adapter - adapts the interface Adaptee to the Target interface.
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public Adapter()
        {

        }

        public override void Request()
        {
            //Possibly do some other work
            //and then call SpecificRequest
            Console.WriteLine(_adaptee.SpecificRsult());
        }
    }
}
