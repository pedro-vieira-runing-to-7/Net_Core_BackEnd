using FluentValidation.Results;
using FSOLID.Commom.Publisher;
using FSOLID.Domain.DTO;
using FSOLID.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Commands
{
    public class NewEstadoCommand : Command
    {
        public NewEstadoCommand(EstadoDTO estado)
        {
            Estado = estado;
        }

        public EstadoDTO Estado { get;  set; }

        public override bool IsValid()
        {
            return new NewEstadoCommandValidation().Validate(this).IsValid;
        }

        public new ValidationResult ValidationResult()
        {
            return new NewEstadoCommandValidation().Validate(this);
        }

    }
}
