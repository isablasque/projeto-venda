using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoVendas2.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("Id")]
        [Display(Name = "Código do fornecedor")]
        public int Id { get; set; }

        [Column("FornecedorCnpj")]
        [Display(Name = "Cnpj do fornecedor")]
        public string FornecedorCnpj { get; set; } = string.Empty;

        [Column("FornecedorNome")]
        [Display(Name = "Nome do fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;
    }
}
