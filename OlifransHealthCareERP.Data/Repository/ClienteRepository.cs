using OlifransHealthCareERP.Core.Domain;
using OlifransHealthCareERP.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.Data.Repository
{
    public class ClienteRepository  //Reponsavel pelo acesso aos dados
    {
        private ContextDBOlifransHealthCare context;

        public ClienteRepository(ContextDBOlifransHealthCare context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {

        }

    }
}
