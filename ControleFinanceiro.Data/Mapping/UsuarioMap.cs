using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.CPF).IsRequired().HasMaxLength(11);
            builder.HasIndex(c => c.CPF).IsUnique();

            builder.Property(c => c.Profissao).IsRequired().HasMaxLength(50);

            builder.HasMany(c => c.Cartoes).WithOne(c => c.Usuario).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(c => c.Despesas).WithOne(c => c.Usuario).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(c => c.Ganhos).WithOne(c => c.Usuario).OnDelete(DeleteBehavior.NoAction);
            
            builder.ToTable("Usuarios");
        }
    }
}
