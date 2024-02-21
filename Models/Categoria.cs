using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVendas2.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Column("Id")]
        [Display(Name = "Código da categoria")]
        public int Id { get; set; }

        [Column("CategoriaNome")]
        [Display(Name = "Nome da categoria")]
        public string CategoriaNome { get; set; } = string.Empty;
    }
}
