using Microsoft.AspNetCore.Mvc;

namespace CadastroDeEmpresas.web.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
