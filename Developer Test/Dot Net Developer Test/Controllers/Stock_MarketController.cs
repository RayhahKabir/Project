using Dot_Net_Developer_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace Dot_Net_Developer_Test.Controllers
{
    public class Stock_MarketController : Controller
    {
        public IActionResult Index()
        {
            var webClient =new WebClient();
            var json = webClient.DownloadString(@"C:\Users\Md. Rayhan Kabir\OneDrive\Desktop\Test\Developer Test\Dot Net Developer Test\wwwroot\lib\stock\Data.json");
            var Stock = JsonConvert.DeserializeObject<stock>(json);
            return View(Stock);
        }
    }
}
