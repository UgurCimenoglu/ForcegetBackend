using Forceget.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Entities.Concrete
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<Offer> Offers { get; set; }

    }
}
