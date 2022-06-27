using Microsoft.Extensions.DependencyInjection;
using MovieinformationService.Domain.Data;
using MovieinformationService.Domain.Services.Implementation;
using MovieinformationService.Domain.Services.Interfaces;
using MovieInformationService.Data.Data;
using MovieInformationService.Data.Database.Settings;
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

            services.AddScoped<IDatabaseSettings, DatabaseSettings>();

            return services;
        }
    }
}
