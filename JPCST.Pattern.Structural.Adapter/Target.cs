using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Structural.Adapter
{
    /// <summary>
    /// Target - defines the domain-specific interface that Client uses.
    /// </summary>
    public class Target
    {
        private string _message = "Target Message: Called Target Request()";

        public Target()
        {

        }

        public virtual void Request()
        {
            Console.WriteLine(_message);
        }
    }
}
