using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ControleFinanceiro.Data.Mapping
{
    public class FuncaoMap : IEntityTypeConfiguration<FuncaoModel>
    {
        public void Configure(EntityTypeBuilder<FuncaoModel> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(50);

            builder.HasData(
                new FuncaoModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Adminstrador",
                    NormalizedName = "ADMINISTRADOR",
                    Descricao = "Administrador do Sistema"

                },

                new FuncaoModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Usuario",
                    NormalizedName = "USUARIO",
                    Descricao = "Usuario do Sistema"
                });

            builder.ToTable("Funcoes");
        }
    }
}
