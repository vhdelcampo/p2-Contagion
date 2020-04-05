using System.Collections.Generic;
using Contagion.API.Repositories;

namespace Contagion.API.Models
{
  
  public class User
  {
    private static UserRepo _up = new UserRepo();

    public int UserPhone { get; set; }
    public decimal Lat { get; set; }
    public decimal Long { get; set; }
    public List<User> users { get; set; }

    // public User()
    // {
    //   users = _up.Get();
    // }
  }
}