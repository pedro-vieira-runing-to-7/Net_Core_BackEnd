using SAGE.Commom.Publisher;
using SAGE.Domain.DTO;
using SAGE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Commands
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
