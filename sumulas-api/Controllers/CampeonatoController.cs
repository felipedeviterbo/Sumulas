using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        //[HttpPost]
        //[ProducesResponseType(typeof(CampeonatoModel), (int)HttpStatusCode.OK)]
        //public async Task<IActionResult> Insert([FromBody]CampeonatoModel campeonato)
        //{
        //    try
        //    {
        //        campeonato = await _campeonatoService.Insert(campeonato);
        //        return Ok(campeonato);
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionViewModel vm = new ExceptionViewModel(LevelException.BusinessRule, ex.Message, HttpStatusCode.BadRequest);
        //        return BadRequest(vm);
        //    }
        //}

        [HttpPost]
        [ProducesResponseType(typeof(CampeonatoModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(CampeonatoModel), (int)HttpStatusCode.BadRequest)]
        public async Task<CampeonatoModel> Insert([FromBody]CampeonatoModel campeonato)
        {
            campeonato = await _campeonatoService.Insert(campeonato);
            return campeonato;
            
        }

        [HttpPut]
        [ProducesResponseType(typeof(CampeonatoModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(CampeonatoModel), (int)HttpStatusCode.NotFound)]
        public async Task<CampeonatoModel> Update(CampeonatoModel campeonato)
        {
            campeonato = await _campeonatoService.Update(campeonato);
            return campeonato;
        }

        [HttpDelete]
        [ProducesResponseType(typeof(CampeonatoModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(CampeonatoModel), (int)HttpStatusCode.NotFound)]
        public async Task<bool> Delete(CampeonatoModel campeonato)
        {
            return await _campeonatoService.Delete(campeonato);
        }

        // CampeonatoModel Update(CampeonatoModel campeonato);
        //bool Delete(CampeonatoModel campeonato);
    }
}