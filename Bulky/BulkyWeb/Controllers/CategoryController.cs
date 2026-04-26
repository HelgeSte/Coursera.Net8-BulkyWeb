using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        //ApplicationDbContext db = new ApplicationDbContext(); // going to use dependency injection instead:
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> varObjCategoryList = _db.Categories.ToList();
            //var objCategoryList = _db.Categories.ToList();
            return View(varObjCategoryList);
        }

        
    }
}
