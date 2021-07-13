﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlifransHealthCareERP.Core.Domain;

namespace OlifransHealthCareERP.Manager.Interfaces
{
    public interface IClienteRepository  //Regras de negócios
    {
        Task<IEnumerable<Cliente>> GetClientesAsync();
        Task<Cliente> GetClientesAsync(int id);
    }
}
