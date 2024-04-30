using AutoMapper;
using BoletosCrud.Dtos;

namespace BoletosCrud.MappingProfiles;

public class BoletosCrudMappingProfiles : Profile
{
    public BoletosCrudMappingProfiles()
    {
        CreateMap<BoletoDTO, Boleto>();
        CreateMap<Boleto, BoletoDTO>();

        CreateMap<BancoDTO, Banco>();
        CreateMap<Banco, BancoDTO>();
    }
}
