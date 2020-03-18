using FSOLID.Commom.Publisher;
using FSOLID.Domain.DTO;
using FSOLID.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Commands
{
    public class NewEnderecoCommand : Command
    {
        public NewEnderecoCommand(EnderecoDTO endereco)
        {
            Endereco = endereco;
        }

        public EnderecoDTO Endereco { get;  set; }

        public override bool IsValid()
        {
            return new NewEnderecoCommandValidation().Validate(this).IsValid;
        }
    }
}
