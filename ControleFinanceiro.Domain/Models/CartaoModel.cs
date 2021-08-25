using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Models
{
    public class CartaoModel : BaseModel
    {
        public string Nome { get; set; }
        public string Bandeira { get; set; }
        public string Numero { get; set; }
        public double Limite { get; set; }
        public DateTime Validade { get; set; }
        public string UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
        public virtual ICollection<DespesaModel> Despesas { get; set; }
    }
}
