using AutoMapper;
using BoletosCrud.Context.Repositories.Contracts;
using BoletosCrud.Dtos;
using BoletosCrud.Services.Contracts;

namespace BoletosCrud.Services;

public class BancoService : IBancoService
{
    private readonly IBancoRepository _bancoRepository;
    private readonly IMapper _mapper;

    public BancoService(IBancoRepository bancoRepository, IMapper mapper)
    {
        _bancoRepository = bancoRepository;
        _mapper = mapper;
    }

    public List<BancoDTO> GetAll()
    {
        return _mapper.Map<List<BancoDTO>>(_bancoRepository.All().ToList());
    }

    public BancoDTO GetByCod(string codigo)
    {
        return _mapper.Map<BancoDTO>(_bancoRepository.Where(x => x.CodigoDoBanco == codigo).Single());
    }
    public BancoDTO CreateBanco(BancoDTO bancoDTO)
    {
        try
        {
            var banco = _mapper.Map<Banco>(bancoDTO);
            _bancoRepository.Add(banco);
            if (_bancoRepository.SaveChanges())
                return bancoDTO;
            throw new Exception("Erro ao incluir o Banco!");
        }
        catch (Exception ex)
        {
            throw new Exception($"{ex.Message} - {ex.StackTrace}");
        }
    }

}
