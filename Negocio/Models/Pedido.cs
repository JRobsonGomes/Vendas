using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Models
{
    [Table("Pedido")]
    class Pedido
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataPedido { get; set; }

        [Range(1, 20)]
        public decimal Desconto { get; set; }

        [Range(1, 20)]
        public decimal ValorTotal { get; set; }

        public IList<Item> ListaItens { get; set; } // Pedido tem uma lista de itens(Composto)
    }
}
