using FluentValidation;
using FSOLID.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Validations
{
    public class UpdatePessoaCommandValidation : AbstractValidator<UpdatePessoaCommand>
    {
        public UpdatePessoaCommandValidation()
        {
            RuleFor(x => x.Pessoa.Id).NotNull().WithMessage("Id deve ser informado");
            RuleFor(x => x.Pessoa.Nome).NotEmpty().WithMessage("Nome deve ser informado");
            RuleFor(x => x.Pessoa.CpfCnpj).NotEmpty().WithMessage("Cpf/Cnpj deve ser informado");
            RuleFor(x => x.Pessoa.IdStatus).GreaterThan(-1).WithMessage("Status deve ser informado");
            RuleFor(x => x.Pessoa.IdTipoPessoa).GreaterThan(-1).WithMessage("Tipo Pessoa deve ser informado");
        }
    }
}
