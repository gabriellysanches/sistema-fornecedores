using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Completo.Models
{
    public class Fornecedor
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(15)]
        [Column("Contato")]
        public string Telefone { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("Cnpj")]
        public string CNPJ { get; set; }

        [MaxLength(1000)]
        [Column("Endereço")]
        public string Endereco { get; set; }
    }
}