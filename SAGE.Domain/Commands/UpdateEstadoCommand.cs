using SAGE.Commom.Publisher;
using SAGE.Domain.DTO;
using SAGE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Commands
{
    public class UpdateEstadoCommand : Command
    {
        public UpdateEstadoCommand(EstadoDTO estado)
        {
            Estado = estado;
        }

        public EstadoDTO Estado { get;  set; }

        public override bool IsValid()
        {
            return new UpdateEstadoCommandValidation().Validate(this).IsValid;
        }
    }
}
