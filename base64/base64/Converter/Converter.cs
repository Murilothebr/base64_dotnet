using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Converter.Converter;

public static class Converter
{
    public static string EncodeToBase64String(string[] args)
    {
        return $"teste string + {args[1]}";
    }

    public static string DecodeFromBase64String(string[] args)
    {
        return $"teste string + {args[1]}";
    }

    public static string EncodeToBase64File(string[] args)
    {
        return $"teste file + {args[1]}";
    }

    public static string DecodeFromBase64File(string[] args)
    {
        return $"teste file + {args[1]}";
    }
}
