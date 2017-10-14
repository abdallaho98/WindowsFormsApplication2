using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
        public class TailleDefferentException : Exception
        {
            public TailleDefferentException() { }
            public TailleDefferentException(string message) : base(message) { }
            public TailleDefferentException(string message, Exception inner) : base(message, inner) { }
            
    }
}
