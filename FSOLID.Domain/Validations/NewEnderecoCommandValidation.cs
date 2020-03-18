using FluentValidation;
using FSOLID.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOLID.Domain.Validations
{
    public class NewEnderecoCommandValidation : AbstractValidator<NewEnderecoCommand>
    {
        public NewEnderecoCommandValidation()
        {
            RuleFor(x => x.Endereco.IdPessoa).NotNull().WithMessage("Pessoa deve ser informado");
            RuleFor(x => x.Endereco.IdTipoEndereco).GreaterThan(-1).WithMessage("Tipo deve ser informado");
            RuleFor(x => x.Endereco.Logradouro).NotEmpty().WithMessage("Logradouro deve ser informado");
            RuleFor(x => x.Endereco.Numero).NotEmpty().WithMessage("Número deve ser informado");
            RuleFor(x => x.Endereco.Bairro).NotEmpty().WithMessage("Bairro deve ser informado");
            RuleFor(x => x.Endereco.Cep).NotEmpty().WithMessage("Cep deve ser informado");
            RuleFor(x => x.Endereco.IdEstado).NotNull().WithMessage("Estado deve ser informado");
        }
    }
}
