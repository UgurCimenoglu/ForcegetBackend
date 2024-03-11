using Forceget.Core.Utilities.Results;
using Forceget.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Business.Abstract
{
    public interface IUnit1Service
    {
        IDataResult<List<Unit1DetailDto>> GetAll();
    }
}
