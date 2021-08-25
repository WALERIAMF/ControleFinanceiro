using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Models
{
    public class DespesaModel : BaseModel
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string MesId { get; set; }
        public string UsuarioId { get; set; }
        public string CategoariaId { get; set; }
        public CategoriaModel Categoria { get; set; }
        public CartaoModel Cartao { get; set; }
        public MesModel Mes { get; set; }
        public UsuarioModel Usuario { get; set; }

    }
}
