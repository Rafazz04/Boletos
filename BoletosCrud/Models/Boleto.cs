using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletosCrud.Models;

[Table("BOLETO")]
public class Boleto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome do pagador é obrigatório!")]
    [MaxLength(200)]
    public string NomePagador { get; set; }
    [Required(ErrorMessage = "O Documento do pagador é obrigatório!")]
    [MaxLength(14)]
    public string DocumentoPagador { get; set; }
    [Required(ErrorMessage = "O nome do beneficiário é obrigatório!")]
    [MaxLength(200)]
    public string NomeBeneficiario { get; set; }
    [Required(ErrorMessage = "O documento do beneficiário é obrigatório!")]
    [MaxLength(14)]
    public string DocumentoBeneficiario { get; set; }
    [Required(ErrorMessage = "O Valor do boleto é obrigatório!")]
    [Column(TypeName = "Numeric(6,2)")]
    public decimal Valor { get; set; }
    [Required(ErrorMessage = "A data de vencimento do boleto é obrigatóra!")]
    public DateTime DataVencimento { get; set; }
    public string Observacao { get; set; }
    [Required(ErrorMessage = "O Banco é obrigatório!")]
    [ForeignKey("Banco")]
    public int BancoId { get; set; }
    public Banco Banco { get; set; }
}
