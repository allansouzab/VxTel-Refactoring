using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VxTel_Refactoring.Domain;
using VxTel_Refactoring.Domain.Plano;

namespace VxTel_Refactoring.WebApi.UseCases.Plano
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoController : ControllerBase
    {
        readonly private ICalcula _calcula;

        public PlanoController(ICalcula calcula)
        {
            _calcula = calcula;
        }

        [HttpGet]
        public ActionResult CalculaValor(int origem, int destino, int tempo, int plano)
        {
            var resultado = new
            {
                valorSemPlano = _calcula.ValorSemPlano(origem, destino, tempo),
                valorComPlano = _calcula.ValorComPlano(origem, destino, tempo, plano)
            };
            return Ok(resultado);
        }
        
    }
}
