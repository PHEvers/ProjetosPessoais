using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Cadastros.Domain.DTO;
using Cadastros.Domain.IServices;
using Cadastros.Web.Models;

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
        public async Task<IActionResult> Index()
        {
            var list = _service.FindAll();
            return View(list);
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
        [HttpPost]
        public async Task<JsonResult> Delete(int? id)
        {
            var retDel = new ReturnJsonDel
            {
                status = "Success",
                code = "200"
            };
            try
            {
                if (await _service.Delete(id ?? 0) <= 0)
                {
                    retDel = new ReturnJsonDel
                    {
                        status = "Error",
                        code = "400"
                    };
                }
            }
            catch (Exception ex)
            {
                retDel = new ReturnJsonDel
                {
                    status = ex.Message,
                    code = "500"
                };
            }
            return Json(retDel);
        }
    }
}
