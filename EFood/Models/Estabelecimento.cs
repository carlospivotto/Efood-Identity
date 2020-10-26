using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFood.Models
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
