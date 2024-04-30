using Microsoft.EntityFrameworkCore;

namespace BoletosCrud.Context;

public class BoletosCrudContext : DbContext
{
    public BoletosCrudContext(DbContextOptions<BoletosCrudContext> options) : base(options) { }

    public DbSet<Boleto> Boletos { get; set; }
    public DbSet<Banco> Bancos { get; set; }

}
