using FSOLID.Commom.Publisher;
using FSOLID.Domain.DTO;
using FSOLID.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Commands
{
    public class UpdatePessoaCommand : Command
    {
        public UpdatePessoaCommand(PessoaDTO pessoa)
        {
            Pessoa = pessoa;
        }

        public PessoaDTO Pessoa { get;  set; }

        public override bool IsValid()
        {
            return new UpdatePessoaCommandValidation().Validate(this).IsValid;
        }
    }
}
