using Negocio.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Negocio.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        //Acessando o contexto
        //static AppDbContext context = new AppDbContext();

        private readonly AppDbContext _context;
        //injeta o contexto no construtor
        public Pedido(AppDbContext contexto)
        {
            _context = contexto;
        }

        public int PedidoId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataPedido { get; set; }

        [Range(0, 100000)]
        public decimal Desconto { get; set; }

        [Range(0, 1000000)]
        public decimal ValorTotal { get; set; }

        public List<Item> ListaItens { get; set; } // Pedido tem uma lista de itens(Composto)

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public static Pedido GetPedido()
        {
            //define uma sessão
            /*ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem um serviço do tipo do nosso contexto 
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o Id do carrinho
            string pedidoId = session.GetString("PedidoId") ?? Guid.NewGuid().ToString();

            //atribui o id do carrinho na Sessão
            session.SetString("PedidoId", carrinhoId);*/

            var context = new AppDbContext();
            try
            {
                return new Pedido(context)
                {
                    //PedidoId = pedidoId
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AdicionarItem(int produtoId, int quantidade)
        {
            var pedidoItem = _context.Itens.SingleOrDefault(
                s => s.Produto.ProdutoId == produtoId && s.Pedido.PedidoId == PedidoId);

            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (pedidoItem == null)
            {
                pedidoItem = new Item()
                {
                    ValorUnitDoItem = produto.Valor,
                    Pedido = this,
                    Produto = produto,
                    Quantidade = quantidade,
                    ValorTotalDoItem = produto.Valor * quantidade
                };
                _context.Itens.Add(pedidoItem);
            }
            else
            {
                pedidoItem.Quantidade += quantidade;
                pedidoItem.ValorTotalDoItem = pedidoItem.ValorUnitDoItem * pedidoItem.Quantidade;
            }
            _context.SaveChanges();
        }

        public int RemoverItem(Produto produto)
        {
            var pedidoItem =
                      _context.Itens.SingleOrDefault(
                          s => s.Produto.ProdutoId == produto.ProdutoId && s.PedidoId == PedidoId);

            var quantidadeLocal = 0;

            if (pedidoItem != null)
            {
                if (pedidoItem.Quantidade > 1)
                {
                    pedidoItem.Quantidade--;
                    quantidadeLocal = pedidoItem.Quantidade;
                }
                else
                {
                    _context.Itens.Remove(pedidoItem);
                }
            }

            _context.SaveChanges();

            return quantidadeLocal;
        }

        public List<Item> GetPedidoItens()
        {
            return ListaItens ??
               (ListaItens =
                   _context.Itens.Where(c => c.PedidoId == PedidoId)
                       .Include(s => s.Produto)
                       .ToList());
        }

        public void LimparItens()
        {
            var pedidoItens = _context.Itens
                             .Where(item => item.PedidoId == PedidoId);

            _context.Itens.RemoveRange(pedidoItens);
            _context.SaveChanges();
        }

        public decimal GetPedidoTotal()
        {
            var total = _context.Itens.Where(c => c.PedidoId == PedidoId)
            .Select(c => c.Produto.Valor * c.Quantidade).Sum();

            return total - Desconto;
        }
    }
}
