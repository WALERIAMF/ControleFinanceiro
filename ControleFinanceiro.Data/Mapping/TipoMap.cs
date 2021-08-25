using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Data.Mapping
{
    public class TipoMap : IEntityTypeConfiguration<TipoModel>
    {
        public void Configure(EntityTypeBuilder<TipoModel> builder)
        {
            builder.HasKey(k => k.IdInterno);
            
            builder.Property(t => t.Nome)
                .IsRequired(true)
                .HasMaxLength(20);

            builder.HasMany(t => t.Categorias)
                .WithOne(t => t.Tipo);

            builder.HasData(new TipoModel
            {
                IdInterno = "1",
                Nome = "Despesa"
            },
            new TipoModel
            {
                IdInterno = "2",
                Nome = "Ganho"
            }
            );
            builder.ToTable("Tipos");
        }
    }
}
