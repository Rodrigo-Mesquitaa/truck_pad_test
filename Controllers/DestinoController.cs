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
    public class DestinoController : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Destino>> Post(
                [FromServices] DataContext context,
                [FromBody] Destino model)
        {

            if (ModelState.IsValid)
            {
                context.Destinos.Add(model);

                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
    }
}