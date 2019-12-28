using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Models
{
    [Table("Fornecedor")]
    class Fornecedor
    {
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public string Cnpj { get; set; }

        [StringLength(200, MinimumLength = 10)]
        [Required]
        public string RazaoSocial { get; set; }
    }
}
