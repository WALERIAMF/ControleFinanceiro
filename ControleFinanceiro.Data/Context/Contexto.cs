using ControleFinanceiro.Data.Mapping;
using ControleFinanceiro.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Data.Context
{
    public class Contexto : IdentityDbContext<UsuarioModel, FuncaoModel, string>
    {
        public DbSet<CartaoModel> Cartoes { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<DespesaModel> Despesas { get; set; }
        public DbSet<FuncaoModel> Funcoes { get; set; }
        public DbSet<GanhoModel> Ganhos{ get; set; }
        public DbSet<MesModel> Meses { get; set; }
        public DbSet<TipoModel> Tipos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CartaoMap());
            builder.ApplyConfiguration(new CategoriaMap());
            builder.ApplyConfiguration(new DespesaMap());
            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new GanhoMap());
            builder.ApplyConfiguration(new MesMap());
            builder.ApplyConfiguration(new TipoMap());            
            builder.ApplyConfiguration(new UsuarioMap());
        }

    }
}
