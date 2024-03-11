using AutoMapper;
using Forceget.Business.Abstract;
using Forceget.Core.Utilities.Results;
using Forceget.DataAccess.Abstract;
using Forceget.Entities.Concrete;
using Forceget.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Business.Concrete
{
    public class IncotermManager : IIncotermService
    {
        private readonly IIncotermDal _incotermDal;
        private readonly IMapper _mapper;

        public IncotermManager(IIncotermDal incotermDal, IMapper mapper)
        {
            _incotermDal = incotermDal;
            _mapper = mapper;
        }
        public IDataResult<List<IncotermDetailDto>> GetAll()
        {
            var data = _incotermDal.GetAll();
            var result = _mapper.Map<List<IncotermDetailDto>>(data);
            return new SuccessDataResult<List<IncotermDetailDto>>(result);
        }
    }
}
