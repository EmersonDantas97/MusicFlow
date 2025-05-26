using System;
using System.Collections.Generic;

namespace MusicFlow.Models
{
    internal class Evento : ICadastro
    {
        public int? Id { get; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public Status Status { get; }
        public DateTime DataEvento { get; set; }
        public string Observacao { get; set; }
        public List<Musica> SetList { get; set; }
        public List<IntegranteBanda> Banda { get; set; }

        public Evento()
        {
        }
    }
}
