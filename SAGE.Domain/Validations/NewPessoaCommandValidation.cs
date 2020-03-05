using FluentValidation;
using SAGE.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.Domain.Validations
{
    public class NewPessoaCommandValidation : AbstractValidator<NewPessoaCommand>
    {
        public NewPessoaCommandValidation()
        {
            RuleFor(x => x.Pessoa.Nome).NotEmpty().WithMessage("Nome deve ser informado");
            RuleFor(x => x.Pessoa.CpfCnpj).NotEmpty().WithMessage("Cpf/Cnpj deve ser informado");
            RuleFor(x => x.Pessoa.IdStatus).GreaterThan(-1).WithMessage("Status deve ser informado");
            RuleFor(x => x.Pessoa.IdTipoPessoa).NotNull().WithMessage("Tipo Pessoa deve ser informado");
        }
    }
}
