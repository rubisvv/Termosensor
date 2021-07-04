using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Termosensor.Models;
using Microsoft.EntityFrameworkCore;

namespace Termosensor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationContext db;
        
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            //IEnumerable<Phone> phones = phoneContext.Phones;
            //ViewBag.Phones = phones;
           
            return View(await db.Temperatures.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }


          
        public IActionResult AddTermorecord()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTermorecord(Temperature termorecord, int Timezone, string TempValueStr)
        {
            //Temperature Temp_termorecord;
            termorecord.Date = DateTime.UtcNow.AddHours(Timezone);
            termorecord.TempValue = termorecord.TempValue / 100; //float.Parse(TempValueStr) / 100;
            db.Temperatures.Add(termorecord);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");

            // test git
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

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
