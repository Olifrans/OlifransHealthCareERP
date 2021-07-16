using FluentValidation;
using OlifransHealthCareERP.Core.Domain;
using OlifransHealthCareERP.CoreShared.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.Manager.Validator
{
    public class ClienteNovoValidator : AbstractValidator<ClienteNovo>
    {
        public ClienteNovoValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().MinimumLength(5).MaximumLength(150);
            RuleFor(x => x.DataNascimento).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(x => x.Documento).NotNull().NotEmpty().MinimumLength(4).MaximumLength(14);
            RuleFor(x => x.Telefone).NotNull().NotEmpty().Matches("[2-9][0-9]{10}").WithMessage("O telefone tem que tem o formato de [2-9][0-9]{10}");
            RuleFor(x => x.Sexo).NotNull().NotEmpty().Must(IsMorF).WithMessage("O sexo precisa ser M ou F");                
        }
        private bool IsMorF(char sexo)
        {
           return sexo == 'M'|| sexo == 'F';
        }
    }
}
