using FSOLID.Commom.Notification;
using FSOLID.Commom.Publisher;
using FSOLID.Domain.DTO;
using FSOLID.Domain.Entities;
using FSOLID.Domain.Events;
using FSOLID.Domain.Interfaces;
using FSOLID.Domain.Validations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FSOLID.Domain.Commands
{
    public class UpdateEnderecoCommandHandler
    {
        private readonly IEnderecoRepository _EnderecoRepository;        
        private readonly DomainNotificationHandler _domainNotificationHandler;
        public UpdateEnderecoCommandHandler(IEnderecoRepository EnderecoRepository,  DomainNotificationHandler domainNotificationHandler)
        {
            _EnderecoRepository = EnderecoRepository;            
            _domainNotificationHandler = domainNotificationHandler;
        }

        public Task<Unit> Handle(UpdateEnderecoCommand command)
        {
            if (!command.IsValid())
            {
                command.ValidationResult().Errors.ToList().ForEach(error => _domainNotificationHandler.Handle(new DomainNotification(command.GetType().ToString(), error.ErrorMessage)));
                return Unit.Task;
            }

            Endereco Endereco = new Endereco(command.Endereco.Id,
                                       command.Endereco.IdPessoa,
                                       command.Endereco.IdStatus,
                                       command.Endereco.IdTipoEndereco,
                                       command.Endereco.Logradouro,
                                       command.Endereco.Numero,
                                       command.Endereco.Bairro,
                                       command.Endereco.Cidade,
                                       command.Endereco.Cep,
                                       command.Endereco.IdEstado);

            _EnderecoRepository.Update(Endereco);

            return Unit.Task;
        }
    }
}
