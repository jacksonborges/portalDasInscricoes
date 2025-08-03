using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace portalDasInscricoes.Models
{
    public class CorridaModel
    {
        public int Id { get; set; }
        public string NomeEvento { get; set; }
        public DateTime DataHora { get; set; }
        public string Local { get; set; }
        public string Distancias { get; set; }
        public string LocalLargadaChegada { get; set; }
        public string Organizadores { get; set; }
        //[NotMapped] - evita que o Entity Framework tente criar essa propriedade na tabela do banco de dados.
        public IFormFile ImagemArquivo { get; set; }
        public string LinkInscricao { get; set; }
        public bool InscricaoAberta { get; set; }
    }

}
