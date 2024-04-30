using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletosCrud.Dtos;

public class BoletoDTO
{
    public string NomePagador { get; set; }
    public string DocumentoPagador { get; set; }
    public string NomeBeneficiario { get; set; }
    public string DocumentoBeneficiario { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataVencimento { get; set; }
    public string Observacao { get; set; }
    public int BancoId { get; set; }
}
