using Contagion.Storage.Models;
using System.Collections.Generic;
using Contagion.Storage.Database;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Contagion.Storage.Repositories
{
  public class UserRepo
  {
    private static ContagionDbContext db = new ContagionDbContext();
    private static ContagionDbContext _cdb = db.Instance;
    public List<User> Get()
    {
      return _cdb.User.ToList();
    }

    public bool Post(User user)
    {
      _cdb.User.Add(user);
      return _cdb.SaveChanges() == 1;
    }
  }
}