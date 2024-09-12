using Abi_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;

namespace Abi_MVC.Controllers
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
            List <FileResponse> strings = new List<FileResponse>();
            var url = "http://localhost:5300/api/App";
            var client = new HttpClient();
            var response=await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content=await response.Content.ReadAsStringAsync();
            var data=JsonConvert.DeserializeObject<List<FileResponse>>(content);
            strings.AddRange(data);


            return View(strings);
        }

        public IActionResult Privacy()
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
