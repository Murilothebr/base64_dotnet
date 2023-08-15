using base64.Converter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base64.Converter;

public class ConvertString : ConvertAbstraction
{
    public override string EncondeStringToBase64()
    {
        throw new NotImplementedException();
    }

    public override string DecodeStringFromBase64()
    {
        throw new NotImplementedException();
    }

    #region error handler
    public override string EncondeFileToBase64()
    {
        throw new NotImplementedException();
    }


    public override string DecodeFileFromBase64()
    {
        throw new NotImplementedException();
    }
    #endregion
}
