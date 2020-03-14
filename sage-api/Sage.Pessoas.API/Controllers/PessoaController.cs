using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sage.Pessoas.Domain;
using Sage.Pessoas.Domain.Interfaces;
using Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels;

namespace Sage.Pessoas.API.Controllers
{
    [ApiController]
    [Route("pessoas")]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;
        private readonly IPessoaRepository _repository;
        private readonly IMapper _mapper;

        public PessoaController(ILogger<PessoaController> logger, IPessoaRepository repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<PessoaViewModel> Get()
        {
            return _mapper.Map<IEnumerable<PessoaViewModel>>(_repository.GetAll(x => x.Endereco));
        }

        [HttpGet("{id:guid}")]
        public PessoaViewModel GetById(Guid id)
        {
            return _mapper.Map<PessoaViewModel>(_repository.GetById(id, x => x.Endereco));
        }


        [HttpPost]
        public IActionResult Post(PessoaViewModel pessoaVM)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResponseData(ModelState));

            var pessoa = _mapper.Map<Pessoa>(pessoaVM);
            var created = _mapper.Map<PessoaViewModel>(_repository.Save(pessoa));

            return Created(nameof(Get), created);
        }

        [HttpPut]
        public IActionResult Put(PessoaViewModel pessoaVM)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResponseData(ModelState));

            if (!pessoaVM.Id.HasValue)
            {
                var response = new ResponseData();
                response.Errors.Add("O Id é obrigatório para a atualização.");
                return BadRequest(response);
            }               

            var pessoaDb = _repository.GetById(pessoaVM.Id.Value, x => x.Endereco);
            var pessoa = _mapper.Map<Pessoa>(pessoaVM);

            pessoa.EnderecoId = pessoaDb.EnderecoId;

            var updated = _mapper.Map<PessoaViewModel>(_repository.Save(pessoa));

            return Ok(updated);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _repository.Delete(id);

            return Ok();
        }
    }
}
