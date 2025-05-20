using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicFlow.Models
{
    public enum Status
    {
        Ativo = 0, Inativo = 1
    }
    internal interface ICadastro
    {
        int? Id { get; set; }
        string Nome { get; set; }
        DateTime DataCadastro { get; set; }
        Status Status { get; set; }
    }
}
