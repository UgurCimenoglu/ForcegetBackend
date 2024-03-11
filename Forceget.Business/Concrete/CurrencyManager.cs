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
    public class CurrencyManager : ICurrencyService
    {
        private readonly ICurrencyDal _currencyDal;
        private readonly IMapper _mapper;

        public CurrencyManager(ICurrencyDal currencyDal, IMapper mapper)
        {
            _currencyDal = currencyDal;
            _mapper = mapper;
        }

        public IDataResult<List<CurrencyDetailDto>> GetAll()
        {
            var data = _currencyDal.GetAll().ToList();
            var result = _mapper.Map<List<CurrencyDetailDto>>(data);
            return new SuccessDataResult<List<CurrencyDetailDto>>(result);
        }
    }
}
