using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Models
{
    public class CategoriaModel : BaseModel
    {
        public string Nome { get; set; }
        public string Icone { get; set; }
        public string TipoId { get; set; }
        public TipoModel Tipo { get; set; }
        public virtual ICollection<DespesaModel> Despesas { get; set; }
        public virtual ICollection<GanhoModel> Ganhos { get; set; }
    }
}
