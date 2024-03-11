using Forceget.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Entities.Concrete
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
