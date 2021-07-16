using AutoMapper;
using OlifransHealthCareERP.Core.Domain;
using OlifransHealthCareERP.CoreShared.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.Manager.Mappings
{
    public class ClienteNovoMappingProfile : Profile
    {
        public ClienteNovoMappingProfile()
        {
            CreateMap<ClienteNovo, Cliente>();;                
        }
    }
}
