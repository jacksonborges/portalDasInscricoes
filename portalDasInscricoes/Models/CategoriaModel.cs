using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalInscricoes.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }

        // FK Evento
        public int EventoId { get; set; }
        public EventoModel Evento { get; set; }

        [Required, StringLength(100)]
        public string NomeCategoria { get; set; } // Ex.: "5K", "10K"

        [Required]
        public decimal Valor { get; set; }

        public int? LimiteParticipantes { get; set; }

        // Relacionamentos
        public ICollection<InscricaoModel> Inscricoes { get; set; }
    }
}
