using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Entities.Dtos
{
    public class OfferAddDto
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
    }
}
