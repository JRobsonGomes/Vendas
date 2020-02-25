using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Models
{
    [Table("Item")]
    public class Item
    {
        public int ItemId { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Range(1, 100000)]
        public decimal ValorUnitDoItem { get; set; }

        [Range(1, 1000000)]
        public decimal ValorTotalDoItem { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }// Um item tem um produto

        /*Para que um item saiba a qual pedido ele pertence é necessário essa propriedade
         (Conceito de composição sendo aplicado)*/
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }

        /*Composição: para criar um item é necessário saber qual pedido ele
         pertence. A classe Item só será criada se tiver um pedido*/
        /*public Item(Pedido pedido) //Verificar
        {
            Pedido = pedido;
        }*/
    }
}
