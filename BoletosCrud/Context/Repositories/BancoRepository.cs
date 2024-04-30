using BoletosCrud.Context.Repositories.Contracts;

namespace BoletosCrud.Context.Repositories;

public class BancoRepository : BaseRepository<Banco>, IBancoRepository
{
    public BancoRepository(BoletosCrudContext context) : base(context)
    {
    }
}
