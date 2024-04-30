using AutoMapper;
using BoletosCrud.Context.Repositories.Contracts;
using BoletosCrud.Dtos;
using BoletosCrud.Services.Contracts;
using BoletosCrud.Utils;

namespace BoletosCrud.Services;

public class BoletoService : IBoletoService
{
    private readonly IBoletoRepository _boletoRepository;
    private readonly IMapper _mapper;
    public BoletoService(IBoletoRepository boletoRepository, IMapper mapper)
    {
        _boletoRepository = boletoRepository;
        _mapper = mapper;
    }
    public BoletoDTO GetById(int id)
    {
        var boleto = _boletoRepository.Include(x => x.Banco).Where(x => x.Id == id).SingleOrDefault();
        var boletoDTO = _mapper.Map<BoletoDTO>(boleto);
        if(boleto != null)
        {
            if(boleto.DataVencimento < DateTime.Today)
            {
                decimal valorJuros = boleto.Valor * (boleto.Banco.PercentualDeJuros / 100);
                boletoDTO.Valor += valorJuros;
            }
        }
       return boletoDTO;
    }
    public BoletoDTO CreateBoleto(BoletoDTO boletoDto)
    {
        try
        {
            boletoDto.DocumentoPagador = Util.LimpaFormatacaoDocumento(boletoDto.DocumentoPagador);
            boletoDto.DocumentoBeneficiario = Util.LimpaFormatacaoDocumento(boletoDto.DocumentoBeneficiario);
            var boleto = _mapper.Map<Boleto>(boletoDto);
            _boletoRepository.Add(boleto);
            if (_boletoRepository.SaveChanges())
                return boletoDto;
            throw new Exception("Erro ao adicionar Boleto!");
        }
        catch(Exception ex) 
        {
            throw new Exception($"{ex.Message} - {ex.StackTrace}");
        }
    }

}
