﻿using Forceget.Core.Utilities.Results;
using Forceget.Entities.Concrete;
using Forceget.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Business.Abstract
{
    public interface IModeService
    {
        IDataResult<List<ModeDetailDto>> GetAll();
    }
}
