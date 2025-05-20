using System;
using System.Collections.Generic;

namespace MusicFlow.Models
{
    internal class IntegranteBanda : ICadastro
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAniversario { get; set; }
        public List<Funcao> Funcoes { get; set; }
        public string Fone { get; set; }
        public Status Status { get; set; }

    }
}
