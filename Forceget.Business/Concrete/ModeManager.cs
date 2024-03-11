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
    public class ModeManager : IModeService
    {
        private readonly IModeDal _modeDal;
        private readonly IMapper _mapper;

        public ModeManager(IModeDal modeDal, IMapper mapper)
        {
            _modeDal = modeDal;
            _mapper = mapper;
        }

        public IDataResult<List<ModeDetailDto>> GetAll()
        {
            var data = _modeDal.GetAll().ToList();
            var result = _mapper.Map<List<ModeDetailDto>>(data);
            return new SuccessDataResult<List<ModeDetailDto>>(result);
        }
    }
}
