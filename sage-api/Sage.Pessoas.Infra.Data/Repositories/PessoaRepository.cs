using Sage.Pessoas.Domain;

namespace Sage.Pessoas.Infra.Data.Repositories
{
    public class PessoaRepository : Repository<Pessoa>
    {
        public PessoaRepository(PessoaContext context) : base(context)
        {
        }
    }
}
