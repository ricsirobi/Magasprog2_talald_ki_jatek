using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitalaloProgram.Exceptions
{
    class NotNullException : Exception
    {
        public NotNullException() : base() { }
        public NotNullException(string msg) : base(msg) { }
    }
}
