using Microsoft.AspNetCore.Mvc;
using OlifransHealthCareERP.Core.Domain;
using OlifransHealthCareERP.CoreShared.ModelViews;
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
            return Ok(await _clienteManager.GetClientesAsync()); //Api status post 200           
        }

        // GET api/<ClientesController>/5 --> Retorna um id especifico
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _clienteManager.GetClientesAsync(id));  //Api status post 200
        }

        // POST api/<ClientesController> --> Inserção de um cliente --> objeto de cliente
        [HttpPost]
        public async Task<IActionResult> Post(ClienteNovo clientenovo)
        {
            var clienteInserido = await _clienteManager.InsertClientesAsync(clientenovo);
            return CreatedAtAction(nameof(Get), new { id = clienteInserido.Id }, clienteInserido); //Api status post 201
        }

        // PUT api/<ClientesController>/5  Crud update
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Cliente cliente)
        {
            var clienteAtualizado = await _clienteManager.UpdateClientesAsync(cliente);
            if (clienteAtualizado == null)
            {
                return NotFound(); //Api status post 404
            }
            return Ok(clienteAtualizado); //Api status post 200
        }

        // DELETE api/<ClientesController>/5  Deleta cliente
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _clienteManager.DeletClientesAsync(id);
            return NoContent();
        }
    }
}
