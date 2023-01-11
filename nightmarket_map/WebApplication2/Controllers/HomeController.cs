using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<NightMarket> nightMarkets = new List<NightMarket>();
            nightMarkets.Add(new NightMarket { Id = "A01", Name = "逢甲夜市", Address = "407台中市西屯區文華路" });
            nightMarkets.Add(new NightMarket { Id = "A02", Name = "一中街商圈", Address = "404台中市北區一中街" });
            nightMarkets.Add(new NightMarket { Id = "A03", Name = "中華路夜市", Address = "400台中市中區公園路" });
            nightMarkets.Add(new NightMarket { Id = "A04", Name = "忠孝路夜市", Address = "402台中市南區忠孝路" });
            nightMarkets.Add(new NightMarket { Id = "A05", Name = "豐原廟東夜市", Address = "420台中市豐原區中正路167巷" });
            nightMarkets.Add(new NightMarket { Id = "A06", Name = "東海夜市", Address = "433台中市龍井區新興路" });
            return View(nightMarkets);
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