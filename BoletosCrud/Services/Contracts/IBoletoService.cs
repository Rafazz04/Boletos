using BoletosCrud.Dtos;

namespace BoletosCrud.Services.Contracts;

public interface IBoletoService
{
    BoletoDTO GetById(int id);
    BoletoDTO CreateBoleto(BoletoDTO boletoDto);
}
