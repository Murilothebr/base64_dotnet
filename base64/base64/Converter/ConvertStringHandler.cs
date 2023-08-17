using Base64Converter.Error_Handler;
using Base64Converter.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Base64Converter.Converter.Converter;

namespace base64.Converter;

public class ConvertStringHandler : ConvertHandler
{
    public override object Handle(object request, string[] args)
    {
        var methodFlag = args[0];

        if (args[1] is "-f")
        {
            return base.Handle(request, args) 
                ?? throw new ArgumentNullException();
        }

        if (methodFlag == "-e")
            return EncodeToBase64String(args);

        if (methodFlag == "-d")
            return DecodeFromBase64String(args);

        throw new WrongArgumentException();
    }
}
