using Base64Converter.Error_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Converter.Handler;

internal class ErrorHandler : ConvertHandler
{
    public override object Handle(object request, string[] args)
    {
        if (! (args[0] is "-h"))
        {
            return base.Handle(request, args)
                ?? throw new ArgumentNullException();
        }

        return "error taltal";
    }
}
