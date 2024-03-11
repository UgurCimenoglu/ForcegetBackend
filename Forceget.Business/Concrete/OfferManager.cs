using AutoMapper;
using Forceget.Business.Abstract;
using Forceget.Core.Utilities.Results;
using Forceget.DataAccess.Abstract;
using Forceget.Entities.Concrete;
using Forceget.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Business.Concrete
{
    public class OfferManager : IOfferService
    {
        private readonly IOfferDal _offerDal;
        private readonly IMapper _mapper;
        public OfferManager(IOfferDal offerDal, IMapper mapper)
        {
            _offerDal = offerDal;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(OfferAddDto data)
        {
            var mappingData = _mapper.Map<Offer>(data);
            var res = await _offerDal.AddAsync(mappingData);
            if (res)
            {
                await _offerDal.SaveAsync();
                return new SuccessResult("Başarılı");
            }
            return new ErrorResult("Hata!");
        }

        public IDataResult<List<Offer>> GetAll()
        {
            var result = _offerDal
                .GetAll()
                .Include(o => o.Mode)
                .Include(o => o.MovementType)
                .Include(o => o.Incoterm)
                .Include(c => c.City)
                .ThenInclude(c => c.Country)
                .Include(o => o.PackageType)
                .Include(o => o.Unit1)
                .Include(o => o.Unit2)
                .Include(o => o.Currency)
                .ToList();
            return new SuccessDataResult<List<Offer>>(result);
        }
    }
}
