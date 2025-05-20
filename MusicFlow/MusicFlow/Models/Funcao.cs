using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
