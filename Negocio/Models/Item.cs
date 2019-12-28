using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Models
{
    [Table("Item")]
    class Item
    {
        public int Id { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Range(1, 20)]
        public decimal ValorTotalDoItem { get; set; }

        public Produto Produto { get; set; }// Um item tem um produto

        /*Para que um item saiba a qual pedido ele pertence é necessário essa propriedade
         (Conceito de composição sendo aplicado)*/
        public Pedido Pedido { get; set; }

        /*Composição: para criar um item é necessário saber qual pedido ele
         pertence. A classe pedido só será criada se tiver um pedido*/
        public Item(Pedido pedido)
        {
            Pedido = pedido;
        }
    }
}
