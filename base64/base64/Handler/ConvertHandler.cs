using Base64Converter.Handler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Converter.Handler;

public abstract class ConvertHandler : IHandler
{
    private IHandler _nextHandler = null!;

    public IHandler SetNext(IHandler handler)
    {
        this._nextHandler = handler;
        return handler;
    }

    public virtual object? Handle(object request, string[] args) => this._nextHandler != null ? this._nextHandler.Handle(request, args) : null;
}

