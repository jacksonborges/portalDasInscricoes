using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDasInscricoes.Repository.Entities
{
    internal class Pagamento
    {
        public int Id { get; set; }

        // FK Inscricao
        public int InscricaoId { get; set; }
        public Inscricao Inscricoes { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required, StringLength(50)]
        public string Metodo { get; set; } // Cartão, PIX, Boleto

        public DateTime? DataPagamento { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Pendente";

        public string TransacaoId { get; set; }
    }
}
