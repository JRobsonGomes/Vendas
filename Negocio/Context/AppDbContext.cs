using Negocio.Models;
using System.Data.Entity;

namespace Negocio.Context
{
    class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {}

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores{ get; set; }
        public DbSet<Item> Itens { get; set; }
    }
}
