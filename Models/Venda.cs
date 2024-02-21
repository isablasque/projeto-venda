using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVendas2.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Column("Id")]
        [Display(Name = "Código da venda")]
        public int Id { get; set; }

        [Column("VendaValorTotal")]
        [Display(Name = "Valor total da venda")]
        public double VendaValorTotal { get; set; }

        [Column("VendaData")]
        [Display(Name = "Data da venda")]
        public DateTime VendaData { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("VendedorId")]
        [Display(Name = "Vendedor")]
        public int VendedorId { get; set; }
        public Vendedor? Vendedor { get; set; }

        [ForeignKey("PagamentoId")]
        [Display(Name = "Pagamento")]
        public int PagamentoId { get; set; }
        public Pagamento? Pagamento { get; set; }

        [NotMapped]
        public List<VendaHasProduto> ProdutosList { get; set; }

    }
}
