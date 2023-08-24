using Base64Converter.Error_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Converter.Handler;

internal class HelpHandler : ConvertHandler
{
    public override object Handle(object request, string[] args)
    {
        if (args.Length == 0)
            return "Run 'base64 -h' for more information";

        if (args[0].Length < 2 || (args[0] is not "-e" && args[0] is not "-d"))
            return "Run 'base64 -h' for more information";

        //ToDo help text of how to run
        if ((args[0] is "-h"))
        {
            return "teach how to handle actions";
        }

        return base.Handle(request, args)
            ?? throw new ArgumentNullException();
    }
}
