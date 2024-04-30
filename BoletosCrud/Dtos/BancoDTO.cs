using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletosCrud.Dtos;

public class BancoDTO
{
    public string NomeDoBanco { get; set; }
    public string CodigoDoBanco { get; set; }
    public decimal PercentualDeJuros { get; set; }
}
