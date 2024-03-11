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
    public class Unit1Manager : IUnit1Service
    {
        private readonly IUnit1Dal _unit1Dal;
        private readonly IMapper _mapper;

        public Unit1Manager(IMapper mapper, IUnit1Dal unit1Dal)
        {
            _mapper = mapper;
            _unit1Dal = unit1Dal;
        }
        public IDataResult<List<Unit1DetailDto>> GetAll()
        {
            var data = _unit1Dal.GetAll().ToList();
            var result = _mapper.Map<List<Unit1DetailDto>>(data);
            return new SuccessDataResult<List<Unit1DetailDto>>(result);
        }
    }
}
