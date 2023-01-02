using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            var memberA = new Member() { Id = 1, Name = "Alex", Age = 12 };
            var memberB = new Member() { Id = 2, Name = "Ben", Age = 34 };
            var memberC = new Member() { Id = 3, Name = "Carol", Age = 56 };
            var memberList = new List<Member>() { memberA, memberB, memberC };
            ViewData["Members"] = memberList;
            //接著將ViewData改寫成ViewBag的方式
            //ViewBag.Members = memberList;
            return View();
        }
    }
}
