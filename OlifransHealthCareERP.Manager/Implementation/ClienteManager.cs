using AutoMapper;
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
        private IMapper _mapper;

        public ClienteManager(IClienteRepository clienteRepository, IMapper mapper)
        {
            this._clienteRepository = clienteRepository;
            this._mapper = mapper;
        }           

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _clienteRepository.GetClientesAsync();
        }



        public async Task<Cliente> GetClientesAsync(int id)
        {
            return await _clienteRepository.GetClientesAsync(id);
        }




        public async Task DeleteClientesAsync(int id)
        {
            await _clienteRepository.DeleteClientesAsync(id);
        }



        public async Task<Cliente> InsertClientesAsync(ClienteNovo clientenovo)
        {
            var cliente = _mapper.Map<Cliente>(clientenovo);
            return await _clienteRepository.InsertClientesAsync(cliente);
        }



        public async Task<Cliente> UpdateClientesAsync(Cliente cliente)
        {
            return await _clienteRepository.UpdateClientesAsync(cliente);
        }
    }
}
