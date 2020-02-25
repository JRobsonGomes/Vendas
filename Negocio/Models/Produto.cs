using Negocio.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Negocio.Models
{
    [Table("Produto")]
    public class Produto
    {
        //Acessando o contexto
        //AppDbContext contexto = new AppDbContext();

        public int ProdutoId { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Descricao { get; set; }

        [StringLength(10, MinimumLength = 1)]
        [Required]
        public string UnidadeMedida { get; set; }

        [Range(1, 20000)]
        [Required]
        public decimal Valor { get; set; }

        public int FornecedorId { get; set; }// Relacionamento: Produto tem um fornecedor
        public virtual Fornecedor Fornecedor { get; set; } //Propriedade de navegaçao

        public void SalvarProduto(int idFornecedor)
        {
            using (var context = new AppDbContext())
            {
                //Procura o fornecedor de acordo com o id passado por parametro
                var fornecedor = context.Fornecedores.FirstOrDefault(f => f.FornecedorId == idFornecedor);
                Fornecedor = fornecedor; //Atribui ao produto um fornecedor sem adicionar em duplicidade um novo fornecedor
                context.Produtos.Add(this);
                context.SaveChanges();
            }
        }

        public void Atualizar(Produto produto)
        {
            using (var context = new AppDbContext())
                context.Entry(produto).State = EntityState.Modified;
        }

        public void Deletar(Produto produto)
        {
            using (var context = new AppDbContext())
                context.Set<Produto>().Remove(produto);
        }

        /*public static List<Produto> Todos() //Esse metodo nao inclui o fornecedor, pois nao tem palavra chave include
        {
            using (var context = new AppDbContext())
                return context.Produtos.ToList();
        }*/

        public static List<Produto> BuscarTodos() //Metodo que inclui fornecedor "Include"
        {
            using (var context = new AppDbContext())
                return context.Produtos.Include(s => s.Fornecedor).ToList();
        }

        public static Produto Buscar(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                    return context.Produtos.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Produto BuscarPorInfo(string descricao)
        {
            try
            {
                using (var context = new AppDbContext())
                    return context.Produtos.Find(descricao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
