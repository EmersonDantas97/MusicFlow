using System;
using System.Collections.Generic;

namespace MusicFlow.Models
{
    internal class Evento : ICadastro
    {
        public int? Id { get; set;  }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public Status Status { get; set; }
        public DateTime DataEvento { get; set; }
        public DateTime HoraEvento { get; set; }
        public string Observacao { get; set; }
        public List<Musica> SetList { get; set; }
        public List<IntegranteBanda> Banda { get; set; }

        public Evento()
        {
        }
    }
}
