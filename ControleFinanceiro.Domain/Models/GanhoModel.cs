using System;

namespace ControleFinanceiro.Domain.Models
{
    public class GanhoModel : BaseModel
    {
        public string Descricao { get; set; }
        public string CategoriaId { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string MesId { get; set; }
        public string UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
        public CategoriaModel Categoria { get; set; }
        public MesModel Mes { get; set; }
    }
}
