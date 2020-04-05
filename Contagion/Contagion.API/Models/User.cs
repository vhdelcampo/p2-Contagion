using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Contagion.API.Repositories;

namespace Contagion.API.Models
{
  
  public class User
  {
    private static UserRepo _up = new UserRepo();

    public int UserPhone { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Lat { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Long { get; set; }
    public List<User> users { get; set; }

    // public User()
    // {
    //   users = _up.Get();
    // }
  }
}