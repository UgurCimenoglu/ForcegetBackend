using Forceget.DataAccess.Abstract;
using Forceget.DataAccess.Context;
using Forceget.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.DataAccess.Concrete
{
    public class Unit1Dal : EfEntityRepositoryBase<Unit1>, IUnit1Dal
    {
        public Unit1Dal(ForcegetDbContext context) : base(context)
        {
        }
    }
}
