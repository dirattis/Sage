using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sage.Pessoas.Domain;
using Sage.Pessoas.Domain.Interfaces;

namespace Sage.Pessoas.API.Controllers
{
    [ApiController]
    [Route("pessoas")]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;
        private readonly IRepository<Pessoa> _repository;

        public PessoaController(ILogger<PessoaController> logger, IRepository<Pessoa> repository)
        {
            _logger = logger;
            _repository = repository;
        }        

        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            return _repository.GetAll();
        }

        [HttpPost]
        public void Post(Pessoa pessoa)
        {
            _repository.Add(pessoa);
            _repository.SaveChanges();
        }
    }
}
