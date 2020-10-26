using System.Collections.Generic;

namespace EFood.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<ProdutoCategoria> ProdutoCategorias { get; set; }
    }
}