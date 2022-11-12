using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public int? Quantidade { get; set; }
        public double? Preco { get; set; }
        public int? CategoriaID { get; set; }
        public Categoria? Categoria { get; set; }
        public ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}
