using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class VectorNullException : Exception

    {
        public VectorNullException() { }
        public VectorNullException(string message) : base(message) { }
        public VectorNullException(string message, Exception inner) : base(message, inner) { }
    }
}
