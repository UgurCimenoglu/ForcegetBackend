using Forceget.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Entities.Concrete
{
    public class Offer : BaseEntity
    {
        public Guid ModeId { get; set; }
        public Guid MovementTypeId { get; set; }
        public Guid IncotermId { get; set; }
        public Guid CityId { get; set; }
        public Guid PackageTypeId { get; set; }
        public Guid Unit1Id { get; set; }
        public Guid Unit2Id { get; set; }
        public Guid CurrencyId { get; set; }
        public int Unit1Value { get; set; }
        public int Unit2Value { get; set; }
        public decimal Price { get; set; }

        public Mode Mode { get; set; }
        public MovementType MovementType { get; set; }
        public Incoterm Incoterm { get; set; }
        public City City { get; set; }
        public PackageType PackageType { get; set; }
        public Unit1 Unit1 { get; set; }
        public Unit2 Unit2 { get; set; }
        public Currency Currency { get; set; }
    }
}
