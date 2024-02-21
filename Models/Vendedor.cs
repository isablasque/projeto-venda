using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVendas2.Models
{
    [Table("Vendedor")]
    public class Vendedor
    {
        [Column("Id")]
        [Display(Name = "Código do vendedor")]
        public int Id { get; set; }

        [Column("VendedorNome")]
        [Display(Name = "Nome do vendedor")]
        public string VendedorNome { get; set; } = string.Empty;
    }
}
