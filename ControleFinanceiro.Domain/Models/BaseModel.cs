using System;
using System.Text.Json.Serialization;

namespace ControleFinanceiro.Domain.Models
{
    public class BaseModel
    {
        public string IdInterno { get; set; }
        [JsonIgnore]
        public DateTime DataCadastro { get; set; }
        [JsonIgnore]
        public DateTime? DataAtualizacao { get; set; }
        public void Novo()
        {
            DataCadastro = DateTime.Now;
        }
        public void Atualizar()
        {
            DataAtualizacao = DateTime.Now;
        }
    }
}
