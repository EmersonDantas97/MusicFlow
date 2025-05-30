using MusicFlow.Models;
using System;
using System.Collections.Generic;
using MusicFlow.Repository;
using System.Threading.Tasks;

namespace MusicFlow.Controller
{
    internal class FuncoesController
    {
        private readonly FuncaoRepository _repository;
        private readonly string _logPath;
        public FuncoesController()
        {
            _repository = new FuncaoRepository(Configurations.Config.GetConnectionString("ConexaoPadrao"));
            _logPath = Configurations.Config.GetLogPath();
        }
        public async Task<List<Funcao>> Get()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch (Exception ex)
            {
                await Utils.Logger.RegistraLog(_logPath, ex);

                throw;
            }
        }
        public async Task<Funcao> Get(int id)
        {
            return await _repository.GetById(id);
        }
        public async Task Post(Models.Funcao funcao)
        {
            if (string.IsNullOrWhiteSpace(funcao.Nome))
                throw new ArgumentException("O nome da função não pode ser vazio.");

            await _repository.Add(funcao);
        }
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
        public async Task Put(int id, Funcao funcao)
        {
            await _repository.Update(funcao);
        }
    }
}
