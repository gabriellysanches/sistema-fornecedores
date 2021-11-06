using System.ComponentModel.DataAnnotations;namespace MVC_Completo.Models{
    public class Usuario
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
    }}