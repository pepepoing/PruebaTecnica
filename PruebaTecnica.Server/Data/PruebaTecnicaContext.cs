using PruebaTecnica.Server.Models;
using Microsoft.EntityFrameworkCore;


namespace PruebaTecnica.Server.Data;

public class PruebaTecnicaContext: DbContext
{
    public DbSet<Client> Clients { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ClientDB;MultipleActiveResultSets=true;User ID=Developer;Password=1SVeryStrongPassword123!!;Trusted_Connection=True");
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ClientDB;Trusted_Connection=True;ConnectRetryCount=0;User ID=Developer;Password=1SVeryStrongPassword123!!");
    }
}

