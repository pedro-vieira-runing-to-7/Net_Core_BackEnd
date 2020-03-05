using SAGE.Commom.Publisher;
using SAGE.Domain.DTO;
using SAGE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Commands
{
    public class NewPessoaCommand : Command
    {
        public NewPessoaCommand(PessoaDTO pessoa)
        {
            Pessoa = pessoa;
        }

        public PessoaDTO Pessoa { get;  set; }

        public override bool IsValid()
        {
            return new NewPessoaCommandValidation().Validate(this).IsValid;
        }
    }
}
