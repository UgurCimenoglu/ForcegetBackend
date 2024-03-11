using Forceget.Business.Abstract;
using Forceget.Business.Concrete;
using Forceget.Core.Utilities.Security.JWT;
using Microsoft.Extensions.DependencyInjection;

namespace Forceget.Business.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IModeService, ModeManager>();
            services.AddScoped<IMovementTypeService, MovementTypeManager>();
            services.AddScoped<IIncotermService, IncotermManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<IPackageTypeService, PackageTypeManager>();
            services.AddScoped<IUnit1Service, Unit1Manager>();
            services.AddScoped<IUnit2Service, Unit2Manager>();
            services.AddScoped<ICurrencyService, CurrencyManager>();
            services.AddScoped<IOfferService, OfferManager>();
        }
    }
}
