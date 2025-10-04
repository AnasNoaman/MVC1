using Microsoft.AspNetCore.Mvc;
using TaskMVC1.Data;

namespace TaskMVC1.Controllers
{
    public class UsersController : Controller
    {
        ApplecationDbContext context= new ApplecationDbContext();
        
        public ViewResult Index()
        {
            var catagory =context.Categorys.ToList();
            return View("Index", catagory);
        }
        public ViewResult Details(int Id )
        {
            
            var teze =context.Categorys.Find(Id) ;
            return View("Details",teze);
        }


        }
}
