using System;
using System.Collections.Generic;
using System.Text;
using Forceget.Core.Entities;

namespace Forceget.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user);
    }
}
