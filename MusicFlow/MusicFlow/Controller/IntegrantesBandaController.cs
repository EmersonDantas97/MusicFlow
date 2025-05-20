using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MusicFlow.Models;
using MusicFlow.Repository;

namespace MusicFlow.Controller
{
    internal class IntegrantesBandaController
    {
        private readonly IntegranteBandaoRepository _repository;
        public IntegrantesBandaController()
        {
            _repository = new IntegranteBandaoRepository();
        }
        public List<IntegranteBanda> BuscarIntegrantesAtivos()
        {
            return _repository.ListarTodos();
        }
        public IntegranteBanda BuscarIntegrante(int id)
        {
            return _repository.ListarPorId(id);
        }
        public IntegranteBanda AdicionarIntegrante(IntegranteBanda integranteBanda)
        {
            if (integranteBanda.Funcoes == null || integranteBanda.Funcoes.Count == 0)
                throw new Exception("É necessário informar ao menus uma função para o integrante.");

            return _repository.Adicionar(integranteBanda);
        }
        public IntegranteBanda ExcluirIntegrante(int id)
        {
            return _repository.Excluir(id);
        }
        public IntegranteBanda EditarIntegrante(int id, IntegranteBanda integranteBanda)
        {
            return _repository.Alterar(id, integranteBanda);
        }

    }
}
