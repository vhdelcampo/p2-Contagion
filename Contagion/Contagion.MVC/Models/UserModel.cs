using Contagion.Storage.Models;
using System.Collections.Generic;
using Contagion.Storage.Repositories;

namespace Contagion.MVC.Models
{
  public class UserModel
  {
    private readonly UserRepo _up = new UserRepo();

    public int UserPhone { get; set; }
    public decimal Lat { get; set; }
    public decimal Long { get; set; }
    public List<User> users { get; set; }
    
    public UserModel()
    {
      users = _up.Get();
    }
  }

  
}