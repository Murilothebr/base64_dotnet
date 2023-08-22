using base64.Converter;
using Base64Converter.Error_Handler;
using Base64Converter.Handler;
using System;

//Todo:
//add flags
//add chain handler / factory Software desing pattern

namespace Base64Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringHandler = new ConvertStringHandler();
            var fileHandler = new ConvertFileHandler();
            var helpHandlher = new HelpHandler();

            helpHandlher.SetNext(stringHandler);
            stringHandler.SetNext(fileHandler);

            var handlerResult = Client.ClientCode(helpHandlher, args);

            Console.WriteLine(handlerResult);
        }
    }
}