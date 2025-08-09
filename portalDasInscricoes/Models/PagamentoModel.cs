using System;
using System.ComponentModel.DataAnnotations;

namespace PortalInscricoes.Models
{
    public class PagamentoModel
    {
        public int Id { get; set; }

        // FK Inscricao
        public int InscricaoId { get; set; }
        public InscricaoModel Inscricao { get; set; }

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
