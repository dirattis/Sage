using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration.AutoMapper
{
    public static class AutoMapperInit
    {
        public static void AddAutoMapperConfig(this IServiceCollection services, Type profileAssembly)
        {

            var profiles = new List<Profile>() 
            { 
                new DomainToViewModelProfile(),
                new ViewModelToDomainProfile()
            };
            services.AddAutoMapper(x => x.AddProfiles(profiles), profileAssembly);

        }
    }
}
