using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Models
{
    [Table("Produto")]
    class Produto
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 10)]
        [Required]
        public string Descricao { get; set; }

        [StringLength(10, MinimumLength = 2)]
        [Required]
        public string UnidadeMedida { get; set; }

        [Range(1,20)]
        [Required]
        public decimal Valor { get; set; }

        public Fornecedor Fornecedor { get; set; } //Relacionamento: Produto tem um fornecedor
    }
}
