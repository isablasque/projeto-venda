using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVendas2.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código do cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone do cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEmail")]
        [Display(Name = "Email do cliente")]
        public string ClienteEmail { get; set; } = string.Empty;
    }
}
