using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Structural.Adapter
{
    /// <summary>
    /// Client - collaborates with objects conforming to the Target interface.
    /// </summary>
    public class Client
    {
        public static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.ReadKey();
        }
    }
}
