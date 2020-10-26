using System.Collections.Generic;

namespace EFood.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<ProdutoCategoria> ProdutoCategorias { get; set; }
    }
}