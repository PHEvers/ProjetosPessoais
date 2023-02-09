using Cadastros.Application.Service.SQLServerServices;
using Cadastros.Domain.DTO;
using Cadastros.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cadastros.Web.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorService _service;
        private readonly IEmpresaService _empresaService;
        public FornecedorController(IFornecedorService service, IEmpresaService empresaService)
        {
            _service = service;
            _empresaService = empresaService;
        }
        public IActionResult Index()
        {
            return View(_service.FindAll());
        }
        public JsonResult ListJson()
        {
            return Json(_service.FindAll());
        }
        public IActionResult Create()
        {
            ViewData["empresaId"] = new SelectList(_empresaService.FindAll(), "id", "nomeFantasia", "Select...");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, empresaId, nome, cpf_cnpj, rg")] FornecedorDTO fornecedor)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(fornecedor) > 0)
                    return RedirectToAction(nameof(Index));
            }
            ViewData["empresaId"] = new SelectList(_empresaService.FindAll(), "id", "nome", "Select...");
            return View(fornecedor);
        }
    }
}
