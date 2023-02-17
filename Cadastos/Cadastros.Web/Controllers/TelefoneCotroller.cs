using Cadastros.Domain.DTO;
using Cadastros.Domain.IServices;
using Cadastros.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cadastros.Web.Controllers
{
    public class TelefoneController : Controller
    {
        private readonly ITelefoneServices _service;
        private readonly IFornecedorService _fornecedorService;
        public TelefoneController(ITelefoneServices service, IFornecedorService fornecedorService)
        {
            _service = service;
            _fornecedorService = fornecedorService;
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
            ViewData["fornecedorId"] = new SelectList(_fornecedorService.FindAll(), "id", "nomeFantasia", "Select...");
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
        /*         [HttpPost]
               public async Task<JsonResult> AddTeledone(int? id)
                {   

                }*/
    }
}
