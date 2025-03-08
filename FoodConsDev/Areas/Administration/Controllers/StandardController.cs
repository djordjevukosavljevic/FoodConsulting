using FoodConsluting.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{

    [Area("Administration")]
    [Route("[area]/[controller]/[action]/{id}")]    
    public class StandardController : Controller
    {
        private readonly IStandardService standardService;
        public StandardController(IStandardService standardService)
        {
            this.standardService = standardService;
        }
        public IActionResult Standards()
        {
            var resultFromDb = standardService.GetAll();
            return View(resultFromDb);
        }

        public IActionResult GetById(int id)
        {
            var resultFromDb = standardService.GetById(id);
            return View(resultFromDb);
        }


    
    }
}
