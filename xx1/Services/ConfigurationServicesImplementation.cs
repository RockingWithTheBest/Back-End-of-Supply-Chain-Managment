using Back_End.Repositories.Implementation;
using Back_End.Repositories.Interfaces;
using SupplyChain.Mapper;

namespace SupplyChain.Services
{
    public class ConfigurationServicesImplementation
    {
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddControllers();
        }

    }
}
