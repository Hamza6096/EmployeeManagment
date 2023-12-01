using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
