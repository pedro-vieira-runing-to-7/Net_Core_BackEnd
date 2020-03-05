using SAGE.Commom.Publisher;
using SAGE.Domain.DTO;
using SAGE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Commands
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
    }
}
