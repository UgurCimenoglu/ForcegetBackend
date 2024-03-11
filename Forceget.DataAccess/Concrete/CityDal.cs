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
    public class CityDal : EfEntityRepositoryBase<City>, ICityDal
    {
        public CityDal(ForcegetDbContext context) : base(context)
        {
        }
    }
}
