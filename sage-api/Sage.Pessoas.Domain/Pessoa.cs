using System;

namespace Sage.Pessoas.Domain
{
    public class Pessoa
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public DateTime Nascimento { get; set; }

        public string TelefoneResidencial { get; set; }

        public string TelefoneCelular { get; set; }

        public string Email { get; set; }

        public Endereco Endereco { get; set; }

    }
}
