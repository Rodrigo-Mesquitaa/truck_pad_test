using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transportadora.Data;
using Transportadora.Entidades;

namespace Transportadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Veiculo>> Post(
               [FromServices] DataContext context,
               [FromBody] Veiculo model)
        {
            if (ModelState.IsValid)
            {
                context.Veiculos.Add(model);

                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        [HttpGet]
        [Route("quantidade-por-data/{data}")]
        public ActionResult<int> GetByData([FromServices] DataContext context, DateTime data)
        {
            var product = context.Terminais.Count(p => p.Data == data);
            return product;
        }
    }
}