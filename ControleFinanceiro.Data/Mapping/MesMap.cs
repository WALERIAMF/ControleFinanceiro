using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Data.Mapping
{
    public class MesMap : IEntityTypeConfiguration<MesModel>
    {
        public void Configure(EntityTypeBuilder<MesModel> builder)
        {
            builder.HasKey(c => c.IdInterno);

            builder.Property(c => c.Nome).IsRequired(true).HasMaxLength(55);
            builder.HasIndex(c => c.Nome).IsUnique();

            builder.HasMany(c => c.Ganhos).WithOne(c => c.Mes).IsRequired(true);
            builder.HasMany(c => c.Despesas).WithOne(c => c.Mes).IsRequired(true);

            builder.HasData(
                new MesModel
                {
                    IdInterno = "1",
                    Nome = "Janeiro"
                },

                new MesModel
                {
                    IdInterno = "2",
                    Nome = "Fevereiro"
                },

                new MesModel
                {
                    IdInterno = "3",
                    Nome = "Março"
                },

                new MesModel
                {
                    IdInterno = "4",
                    Nome = "Abril"
                },

                new MesModel
                {
                    IdInterno = "5",
                    Nome = "Maio"
                },

                new MesModel
                {
                    IdInterno = "6",
                    Nome = "Junho"
                },

                new MesModel
                {
                    IdInterno = "7",
                    Nome = "Julho"
                },

                new MesModel
                {
                    IdInterno = "8",
                    Nome = "Agosto"
                },

                new MesModel
                {
                    IdInterno = "9",
                    Nome = "Setembro"
                },

                new MesModel
                {
                    IdInterno = "10",
                    Nome = "Outubro"
                },

                new MesModel
                {
                    IdInterno = "11",
                    Nome = "Novembro"
                },
                new MesModel
                {
                    IdInterno = "12",
                    Nome = "Dezembro"
                }
                );

            builder.ToTable("Meses");

        }
    }
}

