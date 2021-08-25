using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Models
{
    public class MesModel : BaseModel
    {
        public string Nome { get; set; }
        public virtual ICollection<GanhoModel> Ganhos { get; set; }
        public virtual ICollection<DespesaModel> Despesas { get; set; }
    }
}
