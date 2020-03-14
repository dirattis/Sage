using Microsoft.Extensions.DependencyInjection;
using Sage.Pessoas.Domain.Interfaces;
using Sage.Pessoas.Infra.Data;
using Sage.Pessoas.Infra.Data.Repositories;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration
{
    public static class NativeInjector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<PessoaContext>();

        }
    }
}
