using Microsoft.EntityFrameworkCore;
using OlifransHealthCareERP.Core.Domain;
using OlifransHealthCareERP.Data.Context;
using OlifransHealthCareERP.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.Data.Repository
{
    public class ClienteRepository : IClienteRepository  //Reponsavél pelo acesso aos dados
    {
        private ContextDBOlifransHealthCare _context;

        public ClienteRepository(ContextDBOlifransHealthCare context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _context.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClientesAsync(int id)
        {           
            return await _context.Clientes.FindAsync(id);
        }       
    }
}
