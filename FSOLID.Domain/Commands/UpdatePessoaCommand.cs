using FluentValidation.Results;
using FSOLID.Commom.Publisher;
using FSOLID.Domain.DTO;
using FSOLID.Domain.Validations;

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

        public new ValidationResult ValidationResult()
        {
            return new UpdatePessoaCommandValidation().Validate(this);
        }

    }
}
