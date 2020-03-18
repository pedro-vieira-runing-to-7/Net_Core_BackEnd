using FluentValidation;
using FSOLID.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Validations
{
    public class UpdateEstadoCommandValidation : AbstractValidator<UpdateEstadoCommand>
    {
        public UpdateEstadoCommandValidation()
        {
            RuleFor(x => x.Estado.Nome).NotEmpty().WithMessage("Nome deve ser informado");
            RuleFor(x => x.Estado.Sigla).NotEmpty().WithMessage("Sigla deve ser informado");
        }
    }
}
