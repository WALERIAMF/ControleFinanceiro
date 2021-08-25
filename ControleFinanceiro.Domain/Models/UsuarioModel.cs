using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Models
{
    public class UsuarioModel : IdentityUser<string>
    {
        public string CPF { get; set; }
        public string Profissao { get; set; }
        public byte[] Foto { get; set; }
        public virtual ICollection<CartaoModel> Cartoes{ get; set; }
        public virtual ICollection<DespesaModel> Despesas { get; set; }
        public virtual ICollection<GanhoModel> Ganhos{ get; set; }
    }
}
