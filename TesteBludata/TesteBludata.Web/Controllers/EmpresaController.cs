using Microsoft.AspNetCore.Mvc;

namespace TesteBludata.web.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
