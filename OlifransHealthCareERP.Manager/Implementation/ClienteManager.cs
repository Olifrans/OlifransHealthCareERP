using OlifransHealthCareERP.Core.Domain;
using OlifransHealthCareERP.CoreShared.ModelViews;
using OlifransHealthCareERP.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.Manager.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private IClienteRepository _clienteRepository;

        public ClienteManager(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }             

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _clienteRepository.GetClientesAsync();
        }

        public async Task<Cliente> GetClientesAsync(int id)
        {
            return await _clienteRepository.GetClientesAsync(id);
        }

        public async Task DeletClientesAsync(int id)
        {
            await _clienteRepository.DeletClientesAsync(id);
        }

        public async Task<Cliente> InsertClientesAsync(ClienteNovo cliente)
        {
            return await _clienteRepository.InsertClientesAsync(cliente);
        }

        public async Task<Cliente> UpdateClientesAsync(Cliente cliente)
        {
            return await _clienteRepository.UpdateClientesAsync(cliente);
        }
    }
}
