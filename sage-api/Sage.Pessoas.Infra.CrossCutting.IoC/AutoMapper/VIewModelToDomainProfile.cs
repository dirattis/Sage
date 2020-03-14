

using AutoMapper;
using Sage.Pessoas.Domain;
using Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {             
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<EnderecoViewModel, Endereco>();

        }
    }
}
