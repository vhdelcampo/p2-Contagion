using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Contagion.Storage.Models;

namespace Contagion.Storage.Database
{
  public class ContagionDbContext : DbContext
  {
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=contagiondb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>().HasKey(u => u.UserPhone);
      
      builder.Entity<User>().HasData(new User[]
      {
        new User() { UserPhone = 1234567890, Lat = -13.12M, Long = 16.32M},
        new User() { UserPhone = 0987653432, Lat = 43.54M, Long = -78.65M},
      });
    }
    private static readonly ContagionDbContext _db = new ContagionDbContext();
    public ContagionDbContext Instance { get { return _db; } }
  }
}
// add migration
//dotnet ef migrations add firstmigration -p Contagion.Storage/Contagion.Storage.csproj -s Contagion.MVC/Contagion.MVC.csproj
// start up container
//docker container run -dit --rm --name sqlserver -p 1433:1433 -e 'ACCEPT_EULA=y' -e 'SA_PASSWORD=Password12345' mcr.microsoft.com/mssql/server:2017-latest
// update database
//dotnet ef database update -p Contagion.Storage/Contagion.Storage.csproj  -s Contagion.MVC/Contagion.MVC.csproj