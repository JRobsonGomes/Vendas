using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    [Table("Pedido")]
    class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public IList<Item> ListaItens { get; set; } // Pedido tem uma lista de itens(Composto)
    }
}
