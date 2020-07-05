using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transportadora.Data;
using Transportadora.Entidades;

namespace Transportadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristasController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Motorista>> Post(
                [FromServices] DataContext context,
                [FromBody] Motorista model)
        {
         
            if (ModelState.IsValid)
            {
                context.Motoristas.Add(model);

                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Motorista>> Update(
              [FromServices] DataContext context,
              [FromBody] Motorista model,int id)
        {

            if (id != model.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                context.Entry(model).State = EntityState.Modified;

                 await context.SaveChangesAsync();
            }
            else
            {
                return BadRequest(ModelState);
            }

            return model;

        }

        [HttpGet]
        [Route("buscar-localizacao-por-nome/{nome}")]
        public ActionResult<List<Motorista>> GetByNome([FromServices] DataContext context, string nome)
        {
            var product = context.Motoristas.Include(p => p.Origens).Include(p => p.Destinos).Where(p => p.Nome.Contains(nome)).ToList();
            return product;
        }

        [HttpGet]
        [Route("buscar-sem-carga")]
        public ActionResult<List<Motorista>> GetByNotCarga([FromServices] DataContext context)
        {
            var product = context.Motoristas.Join(context.Veiculos, p => p.IdVeiculo, p => p.Id, (motoristas,veiculo) => new { motoristas, veiculo })
                                            .Where(p => p.veiculo.Carregado == false).Select(p => p.motoristas).ToList();
            return product;
        }

        [HttpGet]
        [Route("quantidade-por-veiculo-proprio")]
        public ActionResult<int> GetByPossuiVeiculo([FromServices] DataContext context)
        {
            var product = context.Motoristas.Count(p => p.PossuirVeiculo == true);
            return product;
        }
    }
}