using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.MyExceptions
{
    public class MyException : ApplicationException
    {
        public MyException() : base("Esta es mi propia excepcion")
        {

        }
    }
}
