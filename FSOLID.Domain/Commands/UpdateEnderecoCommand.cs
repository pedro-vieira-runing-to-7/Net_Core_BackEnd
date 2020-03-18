using FSOLID.Commom.Publisher;
using FSOLID.Domain.DTO;
using FSOLID.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Commands
{
    public class UpdateEnderecoCommand : Command
    {
        public UpdateEnderecoCommand(EnderecoDTO endereco)
        {
            Endereco = endereco;
        }

        public EnderecoDTO Endereco { get;  set; }

        public override bool IsValid()
        {
            return new UpdateEnderecoCommandValidation().Validate(this).IsValid;
        }
    }
}
