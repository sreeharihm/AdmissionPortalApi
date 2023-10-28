using AdmissionPortal.Application.Helpers;
using AdmissionPortal.Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdmissionPortal.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddScoped<IEmailSender, EmailSender>();
        }
    }
}
