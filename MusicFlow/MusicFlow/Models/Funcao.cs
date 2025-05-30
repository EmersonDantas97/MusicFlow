using System;

namespace MusicFlow.Models
{
    internal class Funcao : ICadastro
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public Status Status { get; set; }

        public Funcao()
        {
            DataCadastro = DateTime.Now;
            Status = Status.Ativo;
        }
    }
}
