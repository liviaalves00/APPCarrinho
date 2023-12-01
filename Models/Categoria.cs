using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiviaTaina.Models
{
    public class Categoria
    {
        [Display(Name="Cod Categoria")]
        public int Id {get;set;}
        public string? Nome {get;set;}
        public virtual ICollection<Produto>? Produtos {get;set;}
    }
}