using Cadastros.Domain.DTO;
using Cadastros.Domain.IServices;
using Cadastros.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cadastros.Web.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorService _fornecedorService;
        private readonly IEmpresaService _empresaService;
        private readonly ITelefoneService _telefoneService;
        public FornecedorController(IFornecedorService service, IEmpresaService empresaService, ITelefoneService telefoneService)
        {
            _fornecedorService = service;
            _empresaService = empresaService;
            _telefoneService = telefoneService;
        }
        public async Task<IActionResult> Index()
        {
            var list = _fornecedorService.FindAll();
            return View(list);
        }
        public JsonResult ListJson()
        {
            return Json(_fornecedorService.FindAll());
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
                if (await _fornecedorService.Save(fornecedor) > 0)
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
                if (await _fornecedorService.Delete(id ?? 0) <= 0)
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
