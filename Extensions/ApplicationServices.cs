using MVCDemoS.Data;
using MVCDemoS.Helper;
using MVCDemoS.Interface;
using MVCDemoS.Repository;

namespace MVCDemoS.Extensions
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection service, IConfiguration config)
        {
            service.AddScoped<ISiteInfoRepository, SiteInfoRepository>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            return service; 
        }
    }
}
