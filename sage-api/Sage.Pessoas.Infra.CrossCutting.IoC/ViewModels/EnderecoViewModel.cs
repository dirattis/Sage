﻿
using System;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels
{
    public class EnderecoViewModel
    {
        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
