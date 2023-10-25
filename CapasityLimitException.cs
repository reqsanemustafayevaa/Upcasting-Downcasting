using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk
{
    internal class CapasityLimitException:Exception
    {
        public CapasityLimitException()
        {
            
        }
        public CapasityLimitException(string message):base(message) 
        {
            
        }

    }
    
}
