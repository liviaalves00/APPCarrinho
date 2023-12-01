using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LiviaTaina.Models
{
    public class Produto
    {
        public int Id {get;set;}
        public string? Descricao {get;set;}
        public string? PathImage {get;set;}
        public decimal Preco {get;set;}
        public int Quantidade {get;set;}
        public virtual ICollection<Carrinho>? CarrinhoProduto {get;set;}
        [ForeignKey("Categoria")]
        public int CategoriaId {get;set;}
        public virtual Categoria? Categoria {get;set;}
    }
}