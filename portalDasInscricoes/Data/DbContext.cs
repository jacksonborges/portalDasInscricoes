using Microsoft.EntityFrameworkCore;
using PortalInscricoes.Models;

namespace PortalInscricoes.Data
{
    public class PortalDbContext : DbContext
    {
        // Construtor padrão do EF Core com opções
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
            : base(options)
        {
        }

        // DbSets - use Microsoft.EntityFrameworkCore.DbSet<>
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<EventoModel> Eventos { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<InscricaoModel> Inscricoes { get; set; }
        public DbSet<PagamentoModel> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento 1:1 Inscricao - Pagamento
            modelBuilder.Entity<InscricaoModel>()
                .HasOne(i => i.Pagamento)
                .WithOne(p => p.Inscricao)
                .HasForeignKey<PagamentoModel>(p => p.InscricaoId);
        }
    }
}

