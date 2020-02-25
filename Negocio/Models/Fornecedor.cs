using Negocio.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Negocio.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        public int FornecedorId { get; set; }

        [StringLength(20)]
        [Required]
        public string Cnpj { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string RazaoSocial { get; set; }

        public void Salvar()
        {
            using (var context = new AppDbContext())
            {
                context.Fornecedores.Add(this);
                context.SaveChanges();
            }
        }

        public static List<Fornecedor> BuscarTodos()
        {
            using (var context = new AppDbContext())
                return context.Fornecedores.ToList();
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            using (var context = new AppDbContext())
            {
                context.Entry(fornecedor).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Deletar(int fornecedorId)
        {
            using (var context = new AppDbContext())
            {
                var fornecedor = context.Fornecedores.FirstOrDefault(f => f.FornecedorId == fornecedorId);
                context.Set<Fornecedor>().Remove(fornecedor);
                //context.Fornecedores.Remove(fornecedor); //Outra forma de fazer
                context.SaveChanges();
            }
        }
    }
}
