using SAGE.Commom.Publisher;
using SAGE.Domain.DTO;
using SAGE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Commands
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
