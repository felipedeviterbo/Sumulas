using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sumulas.api.application.Interfaces;
using sumulas.api.application.ViewModel;

namespace sumulas.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampeonatoController : Controller
    {
        private readonly ICampeonatosService _campeonatoService;
        public CampeonatoController(ICampeonatosService campeonatosService)
        {
            _campeonatoService = campeonatosService;
        }


        [HttpGet]
        public ActionResult<List<CampeonatoModel>> Get()
        {
            return _campeonatoService.Get().ToList();
        }
    }
}