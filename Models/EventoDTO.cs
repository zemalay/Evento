using System;
namespace Evento.Models
{
    public class EventoDTO
    {
        private string titulo;
        private string categoria;
        private string token;
        private DateTime data;
        private string lugar;
        private EnderecoDTO endereco;

        public EventoDTO()
        {
        }
    }
}
