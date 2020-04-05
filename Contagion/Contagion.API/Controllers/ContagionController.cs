using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contagion.API.Models;

namespace Contagion.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ContagionController : ControllerBase
  {
    private static readonly List<UserModelApi> _uma = new List<UserModelApi>()
    {
      new UserModelApi() { UserPhone = 8175550150, Lat = 32.7286784M, Long = -97.1046912M},
      new UserModelApi() { UserPhone = 8175550131, Lat = 32.7266784M, Long = -97.1046912M},      
      new UserModelApi() { UserPhone = 8175550117, Lat = 32.7266784M, Long = -97.0846912M},
      new UserModelApi() { UserPhone = 8175550142, Lat = 32.7286784M, Long = -97M},
      new UserModelApi() { UserPhone = 8175550101, Lat = 33M, Long = -97.0846912M},
      new UserModelApi() { UserPhone = 8175550148, Lat = 33M, Long = 97M}
    };

    private readonly ILogger<ContagionController> _logger;

    public ContagionController(ILogger<ContagionController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
      // var res = (new HttpClient()).GetAsync("https://swapi.co/").GetAwaiter().GetResult();
      // var films = res.Content.ReadAsStringAsync();
      return Ok(_uma);
    }

    [HttpPost]
    public IActionResult GetPost([FromBody] UserModelApi uma)
    {      
      _uma.Add(uma);
      return Ok();
    }
  }
}
