using BoletosCrud.Context.Repositories.Contracts;

namespace BoletosCrud.Context.Repositories;

public class BoletoRepository : BaseRepository<Boleto>, IBoletoRepository
{
    public BoletoRepository(BoletosCrudContext context) : base(context)
    {
    }
}
