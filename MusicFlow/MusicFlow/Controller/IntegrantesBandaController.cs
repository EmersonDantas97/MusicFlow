using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<List<IntegranteBanda>> BuscarIntegrantesAtivos()
        {
            return await _repository.GetAll();
        }
        public async Task<IntegranteBanda> BuscarIntegrante(int id)
        {
            return await _repository.Get(id);
        }
        public async Task AdicionarIntegrante(IntegranteBanda integranteBanda)
        {
            if (integranteBanda.Funcoes == null || integranteBanda.Funcoes.Count == 0)
                throw new Exception("É necessário informar ao menus uma função para o integrante.");

            await _repository.Add(integranteBanda);
        }
        public async Task ExcluirIntegrante(int id)
        {
            await _repository.Delete(id);
        }
        public async Task EditarIntegrante(int id, IntegranteBanda integranteBanda)
        {
            await _repository.Update(integranteBanda);
        }

    }
}
