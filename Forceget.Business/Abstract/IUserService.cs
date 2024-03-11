using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forceget.Core.Entities;
using Forceget.Core.Utilities.Results;

namespace Forceget.Business.Abstract
{
    public interface IUserService
    {
        Task<IResult> AddAsync(User user);
        Task<IDataResult<User>> FindByIdAsync(string id);
        Task<IDataResult<User?>> FindByEmailAsync(string email);
    }
}
