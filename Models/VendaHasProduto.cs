using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVendas2.Models
{
    //[Keyless]
    [Table("VendaHasProduto")]
    public class VendaHasProduto
    {
        [Column("Id")]
        [Display(Name = "Código do VendaHasProduto")]
        public int Id { get; set; }

        [ForeignKey("VendaId")]
        [Display(Name = "Venda")]
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("VendaHasQuantidade")]
        [Display(Name = "Quantidade")]
        public int VendaHasQuantidade { get; set; }
    }
}
