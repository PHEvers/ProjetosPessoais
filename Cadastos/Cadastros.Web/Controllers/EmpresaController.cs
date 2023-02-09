using Cadastros.Domain.DTO;
using Cadastros.Domain.IServices;
using Cadastros.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cadastros.Web.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService _service;
        private readonly IUFServices _ufService;
        private readonly IFornecedorService _fornecedorService;
        public EmpresaController(IEmpresaService service, IUFServices uFServices, IFornecedorService fornecedorService)
        {
            _service = service;
            _ufService = uFServices;
            _fornecedorService = fornecedorService;
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
            ViewData["ufId"] = new SelectList(_ufService.FindAll(), "id", "nome", "Select...");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, nomeFantasia, cNPJ, ufId")] EmpresaDTO empresa)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(empresa) > 0)
                    return RedirectToAction(nameof(Index));
            }
            ViewData["ufId"] = new SelectList(_ufService.FindAll(), "id", "nome", "Select...");
            return View(empresa);
        }
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var empresa = await _service.FindById(id);
            ViewData["ufId"] = new SelectList(_ufService.FindAll(), "id", "nome", "Select...");
            return View(empresa);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, nomeFantasia, cNPJ, ufId")] EmpresaDTO empresa)
        {
            if (!(id == empresa.id))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(empresa) > 0)
                    return RedirectToAction(nameof(Index));
            }
            ViewData["ufId"] = new SelectList(_ufService.FindAll(), "id", "nome", "Select...");
            return View(empresa);
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
                };
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
        public async Task<IActionResult> Detalhes(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var empresa = await _service.FindById(id);
            empresa.listaFornecedor = _fornecedorService.FindByEmpresaId(id);
            return View(empresa);
        }

    }
}
