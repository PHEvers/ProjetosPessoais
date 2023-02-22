using Cadastros.Application.Service.SQLServerServices;
using Cadastros.Domain.DTO;
using Cadastros.Domain.Entities;
using Cadastros.Domain.IServices;
using Cadastros.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cadastros.Web.Controllers
{
    public class TelefoneController : Controller
    {
        private readonly ITelefoneService _telefoneService;
        private readonly IFornecedorService _fornecedorService;
        public TelefoneController(ITelefoneService service, IFornecedorService fornecedorService)
        {
            _telefoneService = service;
            _fornecedorService = fornecedorService;
        }
        public async Task<IActionResult> Index()
        {
            var list = _telefoneService.FindAll();
            return View(list);
        }
        public JsonResult ListJson()
        {
            return Json(_telefoneService.FindAll());
        }
        public IActionResult Create()
        {
            ViewData["fornecedorId"] = new SelectList(_fornecedorService.FindAll(), "id", "nome", "Select...");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, numero, fornecedorId")]TelefoneDTO telefone)
        {
            if (ModelState.IsValid)
            {
                if (await _telefoneService.Save(telefone) > 0)
                    return RedirectToAction(nameof(Index));
            }
            ViewData["fornecedorId"] = new SelectList(_fornecedorService.FindAll(), "id", "nome", "Select...");
            return View(telefone);
        }

    }
}
