using System;
using System.ComponentModel.DataAnnotations;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels
{
    public class PessoaViewModel
    {
        public Guid? Id { get; set; }

        [MaxLength(50, ErrorMessage = "O tamanho máximo para o campo Nome é de 50 caractéres.")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo CPF deve possuir 11 caractéres.")]
        public string CPF { get; set; }

        public DateTime Nascimento { get; set; }

        public Int64? TelefoneResidencial { get; set; }

        public Int64? TelefoneCelular { get; set; }

        [MaxLength(50, ErrorMessage = "O tamanho máximo para o campo Email é de 50 caractéres.")]
        public string Email { get; set; }
        
        public EnderecoViewModel Endereco { get; set; }
    }
}
