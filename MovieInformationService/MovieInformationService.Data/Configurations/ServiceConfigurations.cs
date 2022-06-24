using Microsoft.Extensions.DependencyInjection;
using MovieinformationService.Domain.Data;
using MovieinformationService.Domain.Services.Implementation;
using MovieinformationService.Domain.Services.Interfaces;
using MovieInformationService.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationService.Data.Configurations
{
    public static class ServiceConfigurations
    {
        public static IServiceCollection DataConfigurations(this IServiceCollection services)
        {
            services.AddScoped<IMovieInfoData, MovieInfoData>();
            services.AddScoped<IMovieInfoService, MovieInfoService>();

            return services;
        }
    }
}
