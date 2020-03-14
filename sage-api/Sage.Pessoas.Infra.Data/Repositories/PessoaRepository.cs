using Sage.Pessoas.Domain;
using Sage.Pessoas.Domain.Interfaces;
using System;

namespace Sage.Pessoas.Infra.Data.Repositories
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(PessoaContext context) : base(context)
        {
        }

        public Pessoa Save(Pessoa pessoa)
        {
            if (pessoa.Id == default(Guid))
                Add(pessoa);
            else        
                Update(pessoa);                

            SaveChanges();

            return pessoa;
        }
    }
}
