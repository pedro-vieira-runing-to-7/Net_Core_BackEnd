using FSOLID.Commom.Publisher;
using FSOLID.Domain.DTO;
using FSOLID.Domain.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Commands
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

         public new ValidationResult ValidationResult()
        {
            return new NewPessoaCommandValidation().Validate(this);
        }
    }
}
