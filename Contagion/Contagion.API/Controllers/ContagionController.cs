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
    private static readonly List<ContagionModel> _fml = new List<ContagionModel>()
    {
      new ContagionModel() { Title = "Watchmen" },
      new ContagionModel() { Title = "Forest Gump" },
      new ContagionModel() { Title = "Test" },
      new ContagionModel() { Title = "Test 2" },
      new ContagionModel() { Title = "Test 3" },
      new ContagionModel() { Title = "Test 4" }
    };

    private readonly ILogger<ContagionController> _logger;

    public ContagionController(ILogger<ContagionController> logger)
    {
      _logger = logger;
    }

    public IActionResult Get()
    {
      var res = (new HttpClient()).GetAsync("https://swapi.co/").GetAwaiter().GetResult();
      var films = res.Content.ReadAsStringAsync();
      return Ok(_fml);
    }
  }
}
