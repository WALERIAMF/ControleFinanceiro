using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Data.Mapping
{
    public class CategoriaMap : IEntityTypeConfiguration<CategoriaModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaModel> builder)
        {
            builder.HasKey(c => c.IdInterno);
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Icone)
                .IsRequired()
                .HasMaxLength(15);

            builder.HasOne(c => c.Tipo)
                .WithMany(c => c.Categorias)
                .HasForeignKey(c => c.TipoId)
                .IsRequired();

            builder.HasMany(c => c.Ganhos)
                .WithOne(c => c.Categoria);

            builder.HasMany(c => c.Despesas).WithOne(c => c.Categoria);

            builder.ToTable("Categorias");
        }
    }
}
