using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Movimentacao
    {
        public Movimentacao()
        {
            Datamovimentacao = DateTime.Now;
        }
        public int MovimentacaoId { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int? Quantidade { get; set; }
        public string? Descricao { get; set; }
        public DateTime Datamovimentacao { get; set; }
    }
}
