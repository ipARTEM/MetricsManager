using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestMSSQL.Models;

namespace TestMSSQL.Controllers
{
    public class CpuMetricController : Controller
    {
        private readonly ILogger<CpuMetricController> _logger;



        private ApplicationContext db;
        public CpuMetricController(ApplicationContext context, ILogger<CpuMetricController> logger)
        {
            db = context;
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {
            return View(await db.CpuMetrics.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CpuMetric сpuMetric)
        {
            db.CpuMetrics.Add(сpuMetric);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id != null)
        //    {
        //        User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
        //        if (user != null)
        //            return View(user);
        //    }
        //    return NotFound();
        //}



        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id != null)
        //    {
        //        User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
        //        if (user != null)
        //            return View(user);
        //    }
        //    return NotFound();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Edit(User user)
        //{
        //    db.Users.Update(user);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //[ActionName("Delete")]
        //public async Task<IActionResult> ConfirmDelete(int? id)
        //{
        //    if (id != null)
        //    {
        //        User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
        //        if (user != null)
        //            return View(user);
        //    }
        //    return NotFound();
        //}

        

        //[HttpPost]
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id != null)
        //    {
        //        User user = new User { Id = id.Value };
        //        db.Entry(user).State = EntityState.Deleted;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
