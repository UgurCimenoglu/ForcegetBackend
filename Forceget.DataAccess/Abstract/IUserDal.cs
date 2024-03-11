using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forceget.Core.DataAccess;
using Forceget.Core.Entities;

namespace Forceget.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
