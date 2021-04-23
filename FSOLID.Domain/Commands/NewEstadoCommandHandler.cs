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
    public class NewEstadoCommandHandler
    {
        private readonly IEstadoRepository _EstadoRepository;
        private readonly DomainNotificationHandler _domainNotificationHandler;
        public NewEstadoCommandHandler(IEstadoRepository EstadoRepository, DomainNotificationHandler domainNotificationHandler)
        {
            _EstadoRepository = EstadoRepository;
            _domainNotificationHandler = domainNotificationHandler;
        }

        public Task<Unit> Handle(NewEstadoCommand command)
        {
            if (!command.IsValid())
            {
                command.ValidationResult().Errors.ToList().ForEach(error => _domainNotificationHandler.Handle(new DomainNotification(command.GetType().ToString(), error.ErrorMessage)));
                return Unit.Task;
            }
            Estado Estado = new Estado(command.Estado.Sigla,
                                       command.Estado.Nome);

            command.Estado.Id = _EstadoRepository.Add(Estado);

            return Unit.Task;
        }
    }
}
