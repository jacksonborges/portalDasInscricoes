using System;
using System.ComponentModel.DataAnnotations;

namespace PortalInscricoes.Models
{
    public class InscricaoModel
    {
        public int Id { get; set; }

        // FK Usuario
        public int UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }

        // FK Evento
        public int EventoId { get; set; }
        public EventoModel Evento { get; set; }

        // FK Categoria
        public int CategoriaId { get; set; }
        public CategoriaModel Categoria { get; set; }

        public DateTime DataInscricao { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string StatusPagamento { get; set; } = "Pendente";

        public string CodigoPagamento { get; set; }

        // Relacionamento 1:1 com Pagamento
        public PagamentoModel Pagamento { get; set; }
    }
}
