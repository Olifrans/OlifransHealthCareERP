using Microsoft.AspNetCore.Mvc;
using OlifransHealthCareERP.Core.Domain;
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
        // GET: api/<ClientesController> --> Busca uma lista ex: clientes
        [HttpGet]
        //public IEnumerable<Cliente> Get()
        public IActionResult Get()
        {
            return Ok(new List<Cliente>()
            {
                new Cliente
                {
                    Id = 1,
                    Nome = "Francis Oliveira",
                    DataNascimento = new DateTime(1979, 02, 16)
                },

                new Cliente
                {
                    Id = 2,
                    Nome = "Matheus Oliveira",
                    DataNascimento = new DateTime(2007, 02, 16)
                },

                new Cliente
                {
                    Id = 2,
                    Nome = "Samuel Oliveira",
                    DataNascimento = new DateTime(2015, 02, 16)
                },

            });
        }




        // GET api/<ClientesController>/5 --> Retorna um id especifico
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
