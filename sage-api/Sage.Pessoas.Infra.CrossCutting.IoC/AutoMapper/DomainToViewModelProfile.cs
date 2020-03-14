

using AutoMapper;
using Sage.Pessoas.Domain;
using Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {             
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();

        }
    }
}
