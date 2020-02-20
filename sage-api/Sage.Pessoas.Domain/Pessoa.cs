using System;

namespace Sage.Pessoas.Domain
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public DateTime Nascimento { get; set; }

        public Int64? TelefoneResidencial { get; set; }

        public Int64? TelefoneCelular { get; set; }

        public string Email { get; set; }

        public Guid EnderecoId { get; set; }

        public virtual Endereco Endereco { get; set; }

    }
}
