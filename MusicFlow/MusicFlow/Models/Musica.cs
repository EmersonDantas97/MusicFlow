using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicFlow.Models
{
    public enum TomOriginal
    {
        AConfirmar, Sim, Nao
    }
    public enum TemVs
    {
        AConfirmar, Sim, Nao
    }
    internal class Musica : ICadastro
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public Status Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public int VozPrincipal { get; set; }
        public int Bpm { get; set; }
        public string Versao { get; set; }
        public string Compasso { get; set; }
        public string Tom { get; set; }
        public string LinkVideo { get; set; }
        public string LinkCifra { get; set; }
        public TomOriginal TomOriginal { get; set; }
        public TemVs TemVs { get; set; }
        public string Observacao { get; set; }

        public Musica()
        {
        }
    }
}
