using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using AdmissionPortal.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdmissionPortal.Infra.Data
{
    public static class ServiceRegistration
    {
        public static async void AddInfraDataRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SisContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("AdmissionPortalConnection")));

            services.AddScoped<ICountryMasterRepository, CountryMasterRepository>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IApplicantRepository, ApplicantRepository>();
        }
    }
}