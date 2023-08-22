using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Converter.Handler;

public class Client : ConvertHandler
{
    // The client code is usually suited to work with a single handler. In
    // most cases, it is not even aware that the handler is part of a chain.
    public static object ClientCode(ConvertHandler handler, string[] args)
    {
        if (handler is null)
            throw new ArgumentNullException();


        return handler.Handle(args, args)
                ?? throw new ArgumentNullException(); 
    }
}
