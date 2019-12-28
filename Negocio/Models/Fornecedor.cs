using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Models
{
    [Table("Fornecedor")]
    class Fornecedor
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
    }
}
