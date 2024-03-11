using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forceget.DataAccess.Abstract;
using Forceget.DataAccess.Concrete;
using Forceget.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Forceget.DataAccess.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDal, UserDal>();
            services.AddScoped<IModeDal, ModeDal>();
            services.AddScoped<IMovementTypeDal, MovementTypeDal>();
            services.AddScoped<IIncotermDal, IncotermDal>();
            services.AddScoped<ICountryDal, CountryDal>();
            services.AddScoped<ICityDal, CityDal>();
            services.AddScoped<IPackageTypeDal, PackageTypeDal>();
            services.AddScoped<IUnit1Dal, Unit1Dal>();
            services.AddScoped<IUnit2Dal, Unit2Dal>();
            services.AddScoped<ICurrencyDal, CurrencyDal>();
            services.AddScoped<IOfferDal, OfferDal>();
        }
    }
}
