using Microsoft.EntityFrameworkCore;

namespace PortalDasInscricoes.Repository.Context
{
    public class DbPortalDasIncricoesContext : DbContext
    {
        public DbPortalDasIncricoesContext(DbContextOptions<DbPortalDasIncricoesContext> options) : base(options)
        {
        }

        //public DbSet<UsuarioModel> Usuarios { get; set; }
        //public DbSet<EventoModel> Eventos { get; set; }
        //public DbSet<CategoriaModel> Categorias { get; set; }
        //public DbSet<InscricaoModel> Inscricoes { get; set; }
        //public DbSet<PagamentoModel> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
