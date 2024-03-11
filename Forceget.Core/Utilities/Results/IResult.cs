using System;
using System.Collections.Generic;
using System.Text;

namespace Forceget.Core.Utilities.Results
{
    public interface IResult
    {
        string Message { get; }
        bool Success { get; }
    }
}
