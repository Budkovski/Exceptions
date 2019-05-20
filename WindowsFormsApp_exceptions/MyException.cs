using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_exceptions
{
    class MyException : Exception
    {
        double Value { get; }
        public MyException(string message,double value)
            :base(message)
        {
            Value = value;
        }

    }
}
