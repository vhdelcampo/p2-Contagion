using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Contagion.MVC.Models;

namespace Contagion.MVC.Controllers
{
  public class ContagionController : Controller
  {
    private readonly HttpClient _http = new HttpClient();

    private readonly ILogger<HomeController> _logger;

    public ContagionController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      var res = _http.GetAsync("http://api/contagion").GetAwaiter().GetResult();
      var films = JsonConvert.DeserializeObject<List<ContagionViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

      return View(films);
    }
  }
}
