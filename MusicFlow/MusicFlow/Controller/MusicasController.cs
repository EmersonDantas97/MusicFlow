using MusicFlow.Models;
using MusicFlow.Repository;
using System;
using System.Collections.Generic;

namespace MusicFlow.Controller
{
    internal class MusicasController
    {
        private readonly MusicaRepository _repositorio;
        public MusicasController()
        {
            _repositorio = new MusicaRepository();
        }
        public List<Musica> BuscarMusicasAtivas()
        {
            return _repositorio.ListarTodas();
        }
        public Musica BuscarMusica(int id)
        {
            return _repositorio.ListarPorId(id);
        }
        public int AdicionarMusica(Musica musica)
        {
            if (string.IsNullOrWhiteSpace(musica.Nome))
                throw new ArgumentException("O nome da musica não pode ser vazio.");

            return _repositorio.Adicionar(musica);
        }
        public Musica ExcluirMusica(int id)
        {
            return _repositorio.Excluir(id);
        }
        public Musica EditarMusica(int id, Musica musica)
        {
            return _repositorio.Alterar(id, musica);
        }
    }
}
