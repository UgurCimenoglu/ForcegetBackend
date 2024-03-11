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
    public class PackageTypeManager : IPackageTypeService
    {
        private readonly IPackageTypeDal _packageTypeDal;
        private readonly IMapper _mapper;

        public PackageTypeManager(IPackageTypeDal packageTypeDal, IMapper mapper)
        {
            _packageTypeDal = packageTypeDal;
            _mapper = mapper;
        }

        public IDataResult<List<PackageTypeDetailDto>> GetAll()
        {
            var data = _packageTypeDal.GetAll().ToList();
            var result = _mapper.Map<List<PackageTypeDetailDto>>(data);
            return new SuccessDataResult<List<PackageTypeDetailDto>>(result);
        }
    }
}
