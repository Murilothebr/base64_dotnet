using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Converter.Converter;

public static class Converter
{
    public static string EncodeToBase64String(string[] args)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(args[1]));
    }

    public static string DecodeFromBase64String(string[] args)
    {
        return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(args[1]));
    }

    public static string EncodeToBase64File(string[] args)
    {
        Byte[] bytes = File.ReadAllBytes(args[2]);
        return Convert.ToBase64String(bytes);
    }

    public static string DecodeFromBase64File(string[] args)
    {
        Byte[] bytes = Convert.FromBase64String(args[2]);
        File.WriteAllBytes(args[3], bytes);
        return args[3];
    }
}
