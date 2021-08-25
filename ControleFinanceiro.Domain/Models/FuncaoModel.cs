using Microsoft.AspNetCore.Identity;

namespace ControleFinanceiro.Domain.Models
{
    public class FuncaoModel : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
