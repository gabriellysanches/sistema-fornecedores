using System.ComponentModel.DataAnnotations;namespace MVC_Completo.Models{
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
        public string Telefone { get; set; }

        [Required]
        [MaxLength(20)]
        public string CNPJ { get; set; }

        [MaxLength(1000)]
        public string Endereco { get; set; }
    }}