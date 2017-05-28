using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPCST.Pattern.Structural.Adapter
{
    /// <summary>
    /// Adaptee - defines an existing interface that needs adapting.
    /// </summary>
    public class Adaptee
    {
        private string _message = "Adaptee Message: Called SpecificRequest()";

        public Adaptee()
        {

        }

        public virtual string SpecificRsult()
        {
            return _message;
        }
    }
}
