using AutoMapper;
using Forceget.Business.Abstract;
using Forceget.Core.Utilities.Results;
using Forceget.DataAccess.Abstract;
using Forceget.Entities.Dtos;

namespace Forceget.Business.Concrete
{
    public class MovementTypeManager : IMovementTypeService
    {
        private readonly IMovementTypeDal _movementTypeDal;
        private readonly IMapper _mapper;

        public MovementTypeManager(IMapper mapper, IMovementTypeDal movementTypeDal)
        {
            _mapper = mapper;
            _movementTypeDal = movementTypeDal;
        }

        public IDataResult<List<MovementTypeDetailDto>> GetAll()
        {
            var data = _movementTypeDal.GetAll().ToList();
            var result = _mapper.Map<List<MovementTypeDetailDto>>(data);
            return new SuccessDataResult<List<MovementTypeDetailDto>>(result);
        }
    }
}
