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
    public class Unit2Manager : IUnit2Service
    {
        private readonly IUnit2Dal _unit2Dal;
        private readonly IMapper _mapper;

        public Unit2Manager(IMapper mapper, IUnit2Dal unit2Dal)
        {
            _mapper = mapper;
            _unit2Dal = unit2Dal;
        }
        public IDataResult<List<Unit2DetailDto>> GetAll()
        {
            var data = _unit2Dal.GetAll().ToList();
            var result = _mapper.Map<List<Unit2DetailDto>>(data);
            return new SuccessDataResult<List<Unit2DetailDto>>(result);
        }
    }
}
