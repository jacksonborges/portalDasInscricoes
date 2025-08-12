using Microsoft.EntityFrameworkCore;
using PortalDasInscricoes.Repository.Entities;

namespace PortalDasInscricoes.Repository.Context
{
    public class DbPortalDasIncricoesContext : DbContext
    {
        public DbPortalDasIncricoesContext(DbContextOptions<DbPortalDasIncricoesContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
           .HasMany(u => u.Eventos)
           .WithOne(e => e.Organizador)
           .HasForeignKey(e => e.OrganizadorId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Inscricoes)
                .WithOne(i => i.Usuario)
                .HasForeignKey(i => i.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            // ===== EVENTO =====
            modelBuilder.Entity<Evento>()
                .HasMany(e => e.Categorias)
                .WithOne(c => c.Evento)
                .HasForeignKey(c => c.EventoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.Inscricoes)
                .WithOne(i => i.Evento)
                .HasForeignKey(i => i.EventoId)
                .OnDelete(DeleteBehavior.Cascade);

            // ===== CATEGORIA =====
            modelBuilder.Entity<Categoria>()
                .Property(c => c.Valor)
                .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Inscricoes)
                .WithOne(i => i.Categoria)
                .HasForeignKey(i => i.CategoriaId)
                .OnDelete(DeleteBehavior.Cascade);

            // ===== INSCRICAO =====
            modelBuilder.Entity<Inscricao>()
                .HasOne(i => i.Pagamento)
                .WithOne(p => p.Inscricoes)
                .HasForeignKey<Pagamento>(p => p.InscricaoId)
                .OnDelete(DeleteBehavior.Cascade);

            // ===== PAGAMENTO =====
            modelBuilder.Entity<Pagamento>()
                .Property(p => p.Valor)
                .HasColumnType("decimal(10,2)");

            // Valores padrão no banco (garante que não dependa só do C#)
            modelBuilder.Entity<Usuario>()
                .Property(u => u.TipoUsuario)
                .HasDefaultValue("Participante");

            modelBuilder.Entity<Pagamento>()
                .Property(p => p.Status)
                .HasDefaultValue("Pendente");

            modelBuilder.Entity<Evento>()
                .Property(e => e.Situacao)
                .HasDefaultValue("Aberta");
        }
    }
}
