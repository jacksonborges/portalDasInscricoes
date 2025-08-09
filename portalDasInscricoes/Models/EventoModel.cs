using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalInscricoes.Models
{
    public class EventoModel
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nome { get; set; }

        [Required]
        public DateTime DataEvento { get; set; }

        [Required, StringLength(200)]
        public string Local { get; set; }

        [Required, StringLength(2)]
        public string Estado { get; set; }

        [Required, StringLength(100)]
        public string Cidade { get; set; }

        [StringLength(200)]
        public string Endereco { get; set; }

        public string ImagemUrl { get; set; }

        [Required]
        public DateTime DataInicioInscricao { get; set; }

        [Required]
        public DateTime DataFimInscricao { get; set; }

        [StringLength(20)]
        public string Situacao { get; set; } = "Aberta";

        public string Regulamento { get; set; }

        // FK Organizador
        public int OrganizadorId { get; set; }
        public UsuarioModel Organizador { get; set; }

        // Relacionamentos
        public ICollection<CategoriaModel> Categorias { get; set; }
        public ICollection<InscricaoModel> Inscricoes { get; set; }
    }
}
