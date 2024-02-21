using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVendas2.Models
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Column("Id")]
        [Display(Name = "Código do pagamento")]
        public int Id { get; set; }

        [Column("PagamentoForma")]
        [Display(Name = "Forma do pagamento")]
        public string PagamentoForma { get; set; } = string.Empty;
    }
}
