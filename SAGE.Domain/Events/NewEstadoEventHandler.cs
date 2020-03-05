using SAGE.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace SAGE.Domain.Events
{
    public class NewEstadoEventHandler : INotificationHandler<NewEstadoEvent>
    {
        private readonly IEstadoRepository _EstadoRepository;
        public NewEstadoEventHandler(IEstadoRepository EstadoRepository)
        {
            _EstadoRepository = EstadoRepository;
        }
        Task INotificationHandler<NewEstadoEvent>.Handle(NewEstadoEvent newEstadoEvent, CancellationToken cancellationToken)
        {
            _EstadoRepository.Add(newEstadoEvent.Estado);

            return Unit.Task;
        }
    }
}
