using Expance.Data;
using Expance.Data.Services;
using Expance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expance.Controllers
{
    public class FinanceAppController : Controller
    {
        private readonly IExpenceService _expenceService;
        public FinanceAppController(IExpenceService expenceService)
        {
            _expenceService = expenceService;
        } 
        
        public async Task<IActionResult> Index()
        {
            var expence = await _expenceService.GetAll();
            return View(expence);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(FinanceApp expence)
        {
            if(ModelState.IsValid)
            {
                await _expenceService.Add(expence);
                return RedirectToAction("Index");
            }
            
            return View(expence);
        }

        public IActionResult GetChart()
        {
            var data = _expenceService.GetChartData();
            return Json(data);
        }

    }
}
