using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ControleFinanceiro.Data.Mapping
{
    public class CartaoMap : IEntityTypeConfiguration<CartaoModel>
    {
        public void Configure(EntityTypeBuilder<CartaoModel> builder)
        {
            builder.HasKey(c => c.IdInterno);

            builder.Property(c => c.Nome).IsRequired(true)
                .HasMaxLength(55);

            builder.HasIndex(c => c.Nome)
                .IsUnique();

            builder.Property(c => c.Bandeira)
                .IsRequired(true)
                .HasMaxLength(20);

            builder.Property(c => c.Numero)
                .IsRequired(true)
                .HasMaxLength(20);

            builder.HasIndex(c => c.Numero)
                .IsUnique();

            builder.Property(c => c.Limite)
                .IsRequired();

            builder.Property(c => c.Validade)
                .IsRequired(true);

            builder.Property(c => c.DataCadastro)
                .IsRequired(true);

            builder.Property(c => c.DataAtualizacao)
                 .IsRequired(true);

            builder.HasOne(c => c.Usuario)
                .WithMany(c => c.Cartoes)
                .HasForeignKey(c => c.UsuarioId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.Despesas).WithOne(c => c.Cartao);
            builder.ToTable("Cartões");

        }
    }
}
