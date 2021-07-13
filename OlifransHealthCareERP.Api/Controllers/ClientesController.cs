using Microsoft.AspNetCore.Mvc;
using OlifransHealthCareERP.Core.Domain;
using OlifransHealthCareERP.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OlifransHealthCareERP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IClienteManager _clienteManager;

        public ClientesController(IClienteManager clienteManager)
        {
            this._clienteManager = clienteManager;
        }

        // GET: api/<ClientesController> --> Busca uma lista ex: clientes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _clienteManager.GetClientesAsync());           
        }

        // GET api/<ClientesController>/5 --> Retorna um id especifico
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _clienteManager.GetClientesAsync(id));
        }



        // POST api/<ClientesController> --> Inserção de um cliente --> objeto de cliente
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientesController>/5  Crud update
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5  Deleta cliente
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
