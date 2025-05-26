using MusicFlow.Models;
using MusicFlow.Repository;
using System;
using System.Collections.Generic;

namespace MusicFlow.Controller
{
    internal class EventosController
    {
        private readonly EventoRepository _repository;
        public EventosController()
        {
            _repository = new EventoRepository();
        }
        public List<Evento> BuscaEventosAtivos()
        {
            return _repository.ListarTodos(); //TODO: Fazer o método na classe repositório.
        }
        public Evento BuscarEvento(int id)
        {
            return _repository.ListarPorId(id);
        }
        public Evento AdicionarEvento(Evento evento)
        {
            if (string.IsNullOrWhiteSpace(evento.Nome) || evento.Nome.Length < 3)
                throw new ArgumentException("Campo nome não foi preenchido corretamente! Verifique as informações e tente novamente...");

            if (evento.SetList.Count < 1)
                throw new ArgumentException("A setlist não foi preenchida corretamente! Verifique as informações e tente novamente...");

            if (evento.Banda.Count < 2)
                throw new ArgumentException("A banda não foi selecionada corretamente! Verifique as informações e tente novamente...");

            return _repository.Adicionar(evento);
        }
        public Evento ExcluirEvento(int id)
        {
            return _repository.Excluir(id);
        }
        public Evento EditarEvento(int id, Evento evento)
        {
            return _repository.Alterar(id, evento);
        }
    }
}
