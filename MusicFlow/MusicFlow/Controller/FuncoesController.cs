using MusicFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicFlow.Controller
{
    internal class FuncoesController
    {
        private readonly FuncaoRepository _repository;
        public FuncoesController()
        {
            _repository = new FuncaoRepository();
        }
        public List<Funcao> BuscarFuncoesAtivas()
        {
            return _repository.ListarTodas();
        }
        public Funcao BuscarFuncao(int id)
        {
            return _repository.ListarPorId(id);
        }
        public Funcao AdicionarFuncao(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome da função não pode ser vazio.");

            var novaFuncao = new Funcao
            {
                Nome = nome.Trim(),
                DataCadastro = DateTime.Now,
                Status = Status.Ativo // ou Status.0 se estiver usando enum
            };

            return _repository.Adicionar(novaFuncao);
        }
        public Funcao ExcluirFuncao(int id)
        {
            return _repository.Excluir(id);
        }
        public Funcao EditarFuncao(int id, Funcao funcao)
        {
            return _repository.Alterar(id, funcao);
        }

    }
}
