using System;
using System.Collections.Generic;
using System.Text;

namespace Sage.Pessoas.Domain
{
    public class Endereco
    {
        public Guid Id { get; set; }

        public int CEP { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro{ get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
