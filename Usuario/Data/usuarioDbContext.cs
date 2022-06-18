using Microsoft.EntityFrameworkCore;
using Usuario.Model;

namespace Usuario.Data
{
    public class usuarioDbContext : DbContext
    {
        public usuarioDbContext(DbContextOptions<usuarioDbContext> options) : base(options)
        {
        }

        public DbSet<usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario = modelBuilder.Entity<usuario>();
            usuario.ToTable("tb_usuario");
            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            usuario.Property(x => x.DataNascimento).HasColumnName("data_nascimento");
        }
    }
}