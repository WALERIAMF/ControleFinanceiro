using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Data.Mapping
{
    public class GanhoMap : IEntityTypeConfiguration<GanhoModel>
    {
        public void Configure(EntityTypeBuilder<GanhoModel> builder)
        {
            builder.HasKey(c => c.IdInterno);

            builder.Property(c => c.Descricao)
                .IsRequired(true)
                .HasMaxLength(60);

            builder.Property(c => c.Valor)
                .IsRequired(true);

            builder.Property(c => c.Data)
                 .IsRequired(true);

            builder.HasOne(c => c.Categoria)
                .WithMany(g => g.Ganhos)
                .HasForeignKey(c => c.CategoriaId)
                .IsRequired();

            builder.HasOne(c => c.Mes)
                .WithMany(c => c.Ganhos)
                .HasForeignKey(g => g.MesId)
                .IsRequired();

            builder.HasOne(c => c.Usuario)
                .WithMany(c => c.Ganhos)
                .HasForeignKey(c => c.UsuarioId)
                .IsRequired();

            builder.ToTable("Ganhos");
        }
    }
}
