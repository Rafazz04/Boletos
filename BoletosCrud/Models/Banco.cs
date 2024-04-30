using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletosCrud.Models;

[Table("BANCO")]
public class Banco
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome do banco é obrigatório!")]
    [MaxLength(500)]
    public string NomeDoBanco { get; set; }
    [Required(ErrorMessage = "O código do banco é obrigatório!")]
    [MaxLength(100)]
    public string CodigoDoBanco { get; set; }
    [Required(ErrorMessage ="O percentual de juros é obrigatório!")]
    [Column(TypeName = "Numeric(3,2)")]
    public decimal PercentualDeJuros { get; set; }
}
