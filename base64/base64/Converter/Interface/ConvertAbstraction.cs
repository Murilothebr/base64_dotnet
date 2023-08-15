using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base64.Converter.Interface;

public abstract class ConvertAbstraction
{
    public abstract string EncondeStringToBase64();

    public abstract string DecodeStringFromBase64();

    public abstract string EncondeFileToBase64();

    public abstract string DecodeFileFromBase64();
}
