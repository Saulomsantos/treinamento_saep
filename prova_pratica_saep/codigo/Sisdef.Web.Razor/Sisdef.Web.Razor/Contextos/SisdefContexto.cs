using Microsoft.EntityFrameworkCore;
using Sisdef.Web.Razor.Dominios;

namespace Sisdef.Web.Razor.Contextos
{
    public partial class SisdefContexto : DbContext
    {
        public SisdefContexto()
        {
        }

        public SisdefContexto(DbContextOptions<SisdefContexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Defeito> Defeito { get; set; }
        public virtual DbSet<Equipamento> Equipamento { get; set; }
        public virtual DbSet<TipoDefeito> TipoDefeito { get; set; }
        public virtual DbSet<TipoEquipamento> TipoEquipamento { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB08DESK4001; Database=Sisdef_saulo; User Id=sa; pwd=132;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defeito>(entity =>
            {
                entity.Property(e => e.DefeitoId).HasColumnName("defeitoId");

                entity.Property(e => e.DataDefeito).HasColumnName("dataDefeito");

                entity.Property(e => e.DataFinal).HasColumnName("dataFinal");

                entity.Property(e => e.DataInicio).HasColumnName("dataInicio");

                entity.Property(e => e.EquipamentoId).HasColumnName("equipamentoId");

                entity.Property(e => e.TipoDefeitoId).HasColumnName("tipoDefeitoId");

                entity.HasOne(d => d.Equipamento)
                    .WithMany(p => p.Defeito)
                    .HasForeignKey(d => d.EquipamentoId)
                    .HasConstraintName("FK__Defeito__equipam__3E52440B");

                entity.HasOne(d => d.TipoDefeito)
                    .WithMany(p => p.Defeito)
                    .HasForeignKey(d => d.TipoDefeitoId)
                    .HasConstraintName("FK__Defeito__tipoDef__3F466844");
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.Property(e => e.EquipamentoId).HasColumnName("equipamentoId");

                entity.Property(e => e.DataHora)
                    .HasColumnName("dataHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoEquipamentoId).HasColumnName("tipoEquipamentoId");

                entity.HasOne(d => d.TipoEquipamento)
                    .WithMany(p => p.Equipamento)
                    .HasForeignKey(d => d.TipoEquipamentoId)
                    .HasConstraintName("FK__Equipamen__tipoE__3B75D760");
            });

            modelBuilder.Entity<TipoDefeito>(entity =>
            {
                entity.Property(e => e.TipoDefeitoId).HasColumnName("tipoDefeitoId");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEquipamento>(entity =>
            {
                entity.Property(e => e.TipoEquipamentoId).HasColumnName("tipoEquipamentoId");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
