using AutoMapper;
using Forceget.Business.Abstract;
using Forceget.Core.Utilities.Results;
using Forceget.DataAccess.Abstract;
using Forceget.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Business.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;
        private readonly IMapper _mapper;

        public CityManager(IMapper mapper, ICityDal cityDal)
        {
            _mapper = mapper;
            _cityDal = cityDal;
        }
        public IDataResult<List<CityDetailDto>> GetAll()
        {
            var data = _cityDal.GetAll().ToList();
            var result = _mapper.Map<List<CityDetailDto>>(data);
            return new SuccessDataResult<List<CityDetailDto>>(result);
        }
    }
}
