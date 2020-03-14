using System;
using System.Collections.Generic;
using System.Text;

namespace Sage.Pessoas.Domain.Interfaces
{
    public interface IPessoaRepository : IRepository<Pessoa> 
    {
        Pessoa Save(Pessoa pessoa);
    }
}
