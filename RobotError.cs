using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class robotexception : Exception
{
    public string robotstring;
    public robotexception(string message)
        : base(message)
    {
        robotstring = message;
    }
}
