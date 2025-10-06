using Microsoft.AspNetCore.Mvc;
using TaskMVC1.Data;
using TaskMVC1.Models;

namespace TaskMVC1.Controllers
{
    public class UsersController : Controller
    {
        ApplecationDbContext context = new ApplecationDbContext();

        public ViewResult Index()
        {
            var catagory = context.Categorys.ToList();
            return View("Index", catagory);
        }
        public ViewResult Details(int Id)
        {

            var teze = context.Categorys.Find(Id);
            return View("Details", teze);
        }
        public ViewResult Create()
        {

            return View("Create");

        }
        public  IActionResult store(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categorys.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            

            return View("Create",category);
        }
         public ViewResult Edit(int Id)
        {
            var cat = context.Categorys.Find(Id);
            return View("Edit", cat);
        }   
        public ViewResult Update(Category category)
        {
            context.Categorys.Update(category);
            context.SaveChanges();
            var result = context.Categorys.ToList();
            return View("Index", result);
        }
        public ViewResult Delete(int Id)
        {
            var cat = context.Categorys.Find(Id);
            context.Categorys.Remove(cat);
            context.SaveChanges();
            var result = context.Categorys.ToList();
            return View("Index", result);
        }
    }
    
}
