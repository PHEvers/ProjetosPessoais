using Microsoft.AspNetCore.Mvc;
using CadastroDeEmpresas.Domain.IRepositories;
using CadastroDeEmpresas.Domain.Entities;
using CadastroDeEmpresas.Domain.IRepositories;
using CadastroDeEmpresas.Domain.IService;
using CadastroDeEmpresas.Infra.Data.Repositories;
using CadastroDeEmpresas.Infra.Data.Context;

namespace CadastroDeEmpresas.web.Controllers
{
    public class UFController : Controller
    {
        private readonly IUFService _service;
        public UFController(IUFService uFService)
        {
            uFService = uFService;
        }
        public async Task<IActionResult> Index()
        {
            return View(_service.ReadAll);
        }
        public JsonResult ListJson()
        {
            return Json(_service.ReadAll);
        }
        public IActionResult Create()
        {
            return View();
        }


    }
}
