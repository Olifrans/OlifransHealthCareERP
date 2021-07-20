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

        Task<IEnumerable<Cliente>> GetClientesAsync();

        Task<Cliente> GetClientesAsync(int id);  

        Task<Cliente> InsertClientesAsync(ClienteNovo cliente);

        Task<Cliente> UpdateClientesAsync(Cliente cliente);

        Task DeleteClientesAsync(int id);
    }
}
