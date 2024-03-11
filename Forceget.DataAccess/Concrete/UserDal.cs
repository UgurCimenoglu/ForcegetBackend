using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forceget.Core.Entities;
using Forceget.DataAccess.Abstract;
using Forceget.DataAccess.Context;

namespace Forceget.DataAccess.Concrete
{
    public class UserDal : EfEntityRepositoryBase<User>, IUserDal
    {
        public UserDal(ForcegetDbContext context) : base(context)
        {
        }
    }
}
