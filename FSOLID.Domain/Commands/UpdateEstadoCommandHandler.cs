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
    public class UpdateEstadoCommandHandler
    {
        private readonly IEstadoRepository _EstadoRepository;        
        private readonly DomainNotificationHandler _domainNotificationHandler;
        public UpdateEstadoCommandHandler(IEstadoRepository EstadoRepository,  DomainNotificationHandler domainNotificationHandler)
        {
            _EstadoRepository = EstadoRepository;            
            _domainNotificationHandler = domainNotificationHandler;
        }

        public Task<Unit> Handle(UpdateEstadoCommand command)
        {
            if (!command.IsValid())
            {
                command.ValidationResult.Errors.ToList().ForEach(error => _domainNotificationHandler.Handle(new DomainNotification(command.GetType().ToString(), error.ErrorMessage)));
                return Unit.Task;
            }

            Estado Estado = new Estado(command.Estado.Id,
                                       command.Estado.Sigla,
                                       command.Estado.Nome);

            _EstadoRepository.Update(Estado);

            return Unit.Task;
        }
    }
}
