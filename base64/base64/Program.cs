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
            Console.WriteLine($"args: {args.Length}");

            if (args.Length < 3)
                throw new WrongArgumentException();

            var errorHandlher =new Error
            var stringHandler = new ConvertStringHandler();
            var fileHandler = new ConvertFileHandler();

            stringHandler.SetNext(fileHandler);

            Client.ClientCode(stringHandler, args);
        }
    }
}