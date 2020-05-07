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
using Sage.Pessoas.Infra.CrossCutting.Configuration.Extensions;

namespace Sage.Pessoas.API.Controllers
{
    [ApiController]
    [Route("pessoas")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _repository;
        private readonly IMapper _mapper;

        public PessoaController(IPessoaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ResponseData<IEnumerable<PessoaViewModel>>> Get()
        {
            var pessoas = _mapper.Map<IEnumerable<PessoaViewModel>>(_repository.GetAll(x => x.Endereco));
            if (pessoas == null)
                return NoContent();
          
            return Ok(pessoas.ToResponse());
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var pessoa = _mapper.Map<PessoaViewModel>(_repository.GetById(id, x => x.Endereco));

            if (pessoa == null)
                return NoContent();

            return Ok(pessoa.ToResponse());
        }


        [HttpPost]
        public IActionResult Post(PessoaViewModel pessoaVM)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResponseData(ModelState));

            var pessoa = _mapper.Map<Pessoa>(pessoaVM);
            var created = _mapper.Map<PessoaViewModel>(_repository.Save(pessoa));

            return Created(nameof(Get), created.ToResponse());
        }

        [HttpPut]
        public IActionResult Put(PessoaViewModel pessoaVM)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResponseData(ModelState));

            if (!pessoaVM.Id.HasValue)
            {
                var response = new ResponseData("O Id é obrigatório para a atualização.");
                return BadRequest(response);
            }               

            var pessoaDb = _repository.GetById(pessoaVM.Id.Value, x => x.Endereco);
            var pessoa = _mapper.Map<Pessoa>(pessoaVM);

            pessoa.EnderecoId = pessoaDb.EnderecoId;

            var updated = _mapper.Map<PessoaViewModel>(_repository.Save(pessoa));

            return Ok(updated.ToResponse());
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _repository.Delete(id);

            return Ok();
        }
    }
}
