using AutoMapper;
using Forceget.Business.Abstract;
using Forceget.Core.Utilities.Results;
using Forceget.DataAccess.Abstract;
using Forceget.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Business.Concrete
{
    public class CountryManager : ICountryService
    {
        private readonly ICountryDal _countryDal;
        private readonly IMapper _mapper;

        public CountryManager(IMapper mapper, ICountryDal countryDal)
        {
            _mapper = mapper;
            _countryDal = countryDal;
        }

        public IDataResult<List<CountryDetailDto>> GetAll()
        {
            var data = _countryDal.GetAll().Include(c=>c.Cities).ToList();
            var result = _mapper.Map<List<CountryDetailDto>>(data);
            return new SuccessDataResult<List<CountryDetailDto>>(result);
        }
    }
}
