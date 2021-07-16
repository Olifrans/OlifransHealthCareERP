using OlifransHealthCareERP.Core.Domain;
using OlifransHealthCareERP.CoreShared.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.Manager.Interfaces
{
    public interface IClienteManager
    {
        Task DeletClientesAsync(int id);

        Task<Cliente> GetClientesAsync(int id);

        Task<IEnumerable<Cliente>> GetClientesAsync();        

        Task<Cliente> InsertClientesAsync(ClienteNovo cliente);

        Task<Cliente> UpdateClientesAsync(Cliente cliente);
    }
}
