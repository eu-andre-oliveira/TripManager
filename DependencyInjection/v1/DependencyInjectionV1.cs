using Application.v1.Interfaces;
using Application.v1.Service;
using Core.v1.Interfaces;
using Infrastructure.Data;
using Infrastructure.v1.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.v1
{
    public static class DependencyInjectionV1
    {
        
            public static IServiceCollection AddProjectDependenciesV1(this IServiceCollection services)
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseInMemoryDatabase("InMemoryDb"));

            #region services

            services.AddScoped<ITripService, TripService>();
            services.AddScoped<ITripRegistrationService, TripRegistrationService>();
            

            #endregion

            #region repositories

            services.AddScoped<IRegistrationRepository, RegistrationRepository>();
            services.AddScoped<ITripRepository, TripRepository>(); 
            #endregion

            return services;
            }
        
    }
}
