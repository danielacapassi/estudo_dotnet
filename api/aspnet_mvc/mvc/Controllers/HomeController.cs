using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new System.Uri("https://api.github.com");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "request");

            string nome = "danielacapassi";
            string repositorio = "projetonodeavancado";
            HttpResponseMessage resposta = await httpClient.GetAsync($"/repos/{nome}/{repositorio}");
            resposta.EnsureSuccessStatusCode();
            var model = await resposta.Content.ReadFromJsonAsync<Repositorio>();
            Console.WriteLine(model.id);
            Console.WriteLine(model.name);
            Console.WriteLine(model.full_name);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teste()
        {
            return View();
        }

         public IActionResult Open()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
