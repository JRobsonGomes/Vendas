using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    [Table("Produto")]
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Valor { get; set; }
        public Fornecedor Fornecedor { get; set; } //Relacionamento: Produto tem um fornecedor
    }
}
