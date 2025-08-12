using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDasInscricoes.Repository.Entities
{
    internal class Inscricao
    {
        public int Id { get; set; }

        // FK Usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // FK Evento
        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        // FK Categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public DateTime DataInscricao { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string StatusPagamento { get; set; } = "Pendente";

        public string CodigoPagamento { get; set; }

        // Relacionamento 1:1 com Pagamento
        public Pagamento Pagamento { get; set; }
    }
}
