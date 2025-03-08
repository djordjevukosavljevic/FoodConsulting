using FoodConsluting.Data;
using FoodConsluting.Models;
using FoodConsluting.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{

    [Area("Administration")]
    [Route("[area]/[administration]/[controller]/[action]")]
    public class StandardController : Controller
    {
        private readonly IStandardService standardService;
        public StandardController(IStandardService standardService)
        {
            this.standardService = standardService;
        }
        public IActionResult Standards()
        {
            List<StandardModel> standards = standardService.GetAll();
            return View(standards);
        }

        // public IActionResult GetById(int id)
        // {
        //     var resultFromDb = standardService.GetById(id);
        //     return View(resultFromDb);
        // }



    }
}
