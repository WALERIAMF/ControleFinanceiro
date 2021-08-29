using ControleFinanceiro.Data.Context;
using ControleFinanceiro.Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.IO;

namespace ControleFinanceiro.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Contexto>(opcoes => opcoes
                    .UseSqlServer(Configuration.GetConnectionString("ConexaoBD")));


            services.AddIdentity<UsuarioModel, FuncaoModel>().AddEntityFrameworkStores<Contexto>();

            services.AddCors();

            services.AddSpaStaticFiles(diretorio =>
            {
                diretorio.RootPath = "ControleFinanceiroUI";
            });
            services.AddControllers()
                .AddJsonOptions(opcoes =>
                {
                    opcoes.JsonSerializerOptions.IgnoreNullValues = true;
                })
                .AddNewtonsoftJson(opcoes =>
                {
                    opcoes.SerializerSettings
                          .ReferenceLoopHandling = Newtonsoft.Json
                          .ReferenceLoopHandling.Ignore;
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ControleFinanceiro.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ControleFinanceiro.Api v1"));
            }

            app.UseCors(opcoes => opcoes.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSpaStaticFiles();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = Path.Combine(Directory.GetCurrentDirectory(), "ControleFinanceiroUI");

                if (env.IsDevelopment()) 
                {
                    spa.UseProxyToSpaDevelopmentServer($"https://localhost:5001/");
                }
            });

        }
    }
}
