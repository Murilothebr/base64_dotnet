using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Converter.Error_Handler;

public class WrongArgumentException : Exception
{
    public WrongArgumentException(string message = "try -h for how to use base64 flags")
        : base(message)
    {
    }

    public WrongArgumentException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
