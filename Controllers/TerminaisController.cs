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
    public class TerminaisController : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Terminal>> Post(
                [FromServices] DataContext context,
                [FromBody] Terminal model)
        {

            if (ModelState.IsValid)
            {
                context.Terminais.Add(model);

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