using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalInscricoes.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required, StringLength(14)]
        public string CPF { get; set; }

        [Required, StringLength(150)]
        public string NomeCompleto { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required, StringLength(1)]
        public string Sexo { get; set; } // M, F, O

        [Required, StringLength(150)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefone { get; set; }

        [StringLength(50)]
        public string Pais { get; set; } = "Brasil";

        [StringLength(2)]
        public string Estado { get; set; }

        [Required]
        public string SenhaHash { get; set; }

        [StringLength(20)]
        public string TipoUsuario { get; set; } = "Participante"; // ou Organizador

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        // Relacionamentos
        public ICollection<EventoModel> Eventos { get; set; }
        public ICollection<InscricaoModel> Inscricoes { get; set; }
    }
}

