using BoletosCrud.Dtos;

namespace BoletosCrud.Services.Contracts;

public interface IBancoService
{
    List<BancoDTO> GetAll();
    BancoDTO GetByCod(string id);
    BancoDTO CreateBanco(BancoDTO bancoDTO);
}
