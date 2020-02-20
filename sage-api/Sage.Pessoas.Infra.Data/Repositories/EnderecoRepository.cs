using Sage.Pessoas.Domain;

namespace Sage.Pessoas.Infra.Data.Repositories
{
    public class EnderecoRepository : Repository<Endereco>
    {
        public EnderecoRepository(PessoaContext context) : base(context)
        {
        }
    }
}
