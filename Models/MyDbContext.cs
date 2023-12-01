using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LiviaTaina.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }

       public DbSet<Usuario> Usuarios {get;set;}
       public DbSet<Carrinho> Carrinhos {get;set;}
       public DbSet<Produto> Produtos {get;set;}
       public DbSet<Categoria> Categorias {get;set;}
        
    }
}

/*
Cannot add or update a child row: a foreign key constraint fails (`LiviaTaina`.`CarrinhoProduto`, CONSTRAINT `FK_CarrinhoProduto_Carrinhos_CarrinhoProdutoId` FOREIGN KEY (`CarrinhoProdutoId`) REFERENCES `Carrinhos` (`Id`) ON DELETE CASCADE)
mysql> INSERT INTO CarrinhoProduto VALUES(CarrinhoProdutoId=1,CarrinhoProdutoId=2);
*/

