using System.ComponentModel.DataAnnotations;namespace MVC_Completo.Models{
    public class Produto
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(1000)]
        public string Descricao { get; set; }

        [Required]
        public double Valor { get; set; }
    }}