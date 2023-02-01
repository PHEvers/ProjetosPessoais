using Microsoft.AspNetCore.Mvc;
using RevisaoProjetoNoticias.Domain.IRepositories;
using TesteBludata.Domain.Entities;
using TesteBludata.Domain.IRepositories;
using TesteBludata.Domain.IService;
using TesteBludata.Infra.Data.Repositories;
using TesteDatablu.Infra.Data.Context;

namespace TesteBludata.web.Controllers
{
    public class UFController : Controller
    {
        private readonly IUFService _service;
        public UFController(IUFService uFService)
        {
            _UFService = uFService;
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
