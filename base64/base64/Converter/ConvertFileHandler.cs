using Base64Converter.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Base64Converter.Converter.Converter;

namespace base64.Converter;

public class ConvertFileHandler : ConvertHandler
{
    public override object? Handle(object request, string[] args)
    {
        var methodFlag = args[0];

        if (args.Length > 4 || args[1] is not "-f")
           return "Run 'base64 -h' for more information";

        if (methodFlag == "-e")
            return EncodeToBase64File(args);

        if (methodFlag == "-d")
            return DecodeFromBase64File(args);

        return "Run 'base64 -h' for more information";
    }
}
