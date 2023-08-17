using Base64Converter.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base64.Converter;

public class ConvertFileHandler : ConvertHandler
{
    public override object? Handle(object request, string[] args)
    {
        if ((request as string[])[2] is "-f")
        {
            return base.Handle(request, args);
        }

        return "";
    }
}
