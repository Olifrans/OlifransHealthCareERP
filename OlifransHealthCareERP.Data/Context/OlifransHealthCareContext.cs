
using Microsoft.EntityFrameworkCore;
using OlifransHealthCareERP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.Data.Context
{
    class OlifransHealthCareContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public OlifransHealthCareContext(DbContextOptions options) : base(options)
        {
                
        }
    }
}
