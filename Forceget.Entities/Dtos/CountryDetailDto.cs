using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Entities.Dtos
{
    public class CountryDetailDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<CityDetailForCountryDto>? Cities { get; set; }
    }

    public class CityDetailForCountryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
