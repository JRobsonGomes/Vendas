using Negocio.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace Negocio.Context
{
    public class AppDbContext : DbContext
    {
        //Construtor
        public AppDbContext() : base()
        {}

        //Override para ver os erros do metodo SaveChanges()
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                    eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores{ get; set; }
        public DbSet<Item> Itens { get; set; }
    }
}
