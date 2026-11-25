using GymManagmentSystem.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Controllers
{
    public class PlanController : Controller
    {
        private GymdbContext gymdbContext = new GymdbContext(); 
        public async Task<IActionResult> Index()
        {
            var Plans = await gymdbContext.Plans.ToListAsync();
            return View(Plans);
        }
    }
}
