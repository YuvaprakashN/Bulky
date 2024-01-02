using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {

        private ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Models.Category> categories = _db.Categories.ToList();
            return View(categories);
        }


        public IActionResult Create() { 
        
            return View();
        }


        [HttpPost]
        public IActionResult Create(Category category)
        {
          /*  if(category.Name.ToLower() == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Display order cannot match the same");
            }*/

            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }

            
            return View();


        }



        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Category? category = _db.Categories.Find(id);
            if(category == null)
            {
                return NotFound();
            }


            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Category category)
        {
         
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
            TempData["success"] = "Category edited successfully";
                return RedirectToAction("Index");
            }
            return View();


        }



        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }


            return View(category);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            TempData["success"] = "Category deleted successfully";
                _db.Categories.Remove(category);
                _db.SaveChanges();
           
            return RedirectToAction("Index");


        }
    }
}
