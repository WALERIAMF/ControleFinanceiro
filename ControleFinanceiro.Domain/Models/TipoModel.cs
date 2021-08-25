using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Models
{
    public class TipoModel : BaseModel
    {
        public string Nome { get; set; }
        public virtual ICollection<CategoriaModel> Categorias { get; set; }
    }
}
