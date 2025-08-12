using System.ComponentModel.DataAnnotations;

namespace PortalDasInscricoes.Repository.Entities
{
    public class Categoria
    {        
        public int Id { get; set; }
        // FK Evento
        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        [Required, StringLength(100)]
        public string NomeCategoria { get; set; } // Ex.: "5K", "10K"

        [Required]
        public decimal Valor { get; set; }

        public int? LimiteParticipantes { get; set; }

        // Relacionamentos
        public ICollection<Inscricao> Inscricoes { get; set; }

    }
}
