using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Data.Mapping

{
    public class DespesaMap : IEntityTypeConfiguration<DespesaModel>
    {
        public void Configure(EntityTypeBuilder<DespesaModel> builder)
        {
            builder.HasKey(c => c.IdInterno);

            builder.Property(c => c.Descricao)
                .IsRequired(true)
                .HasMaxLength(60);

            builder.Property(c => c.Valor)
                .IsRequired(true)
                .HasMaxLength(60);

            builder.Property(c => c.Data)
                .IsRequired(true);

            builder.Property(c => c.DataAtualizacao)
                 .IsRequired(true);

            builder.HasOne(c => c.Categoria)
                .WithMany(c => c.Despesas)
                .HasForeignKey(c => c.CategoariaId)
                .IsRequired();

            builder.HasOne(c => c.Cartao)
                .WithMany(c => c.Despesas)
                .HasForeignKey(c => c.IdInterno)
                .IsRequired();

            builder.HasOne(c => c.Mes)
                .WithMany(c => c.Despesas)
                .HasForeignKey(c => c.MesId)
                .IsRequired();

            builder.HasOne(c => c.Usuario)
                .WithMany(c => c.Despesas)
                .HasForeignKey(c => c.UsuarioId)
                .IsRequired();

            builder.ToTable("Despesas");
        }
    }
}
