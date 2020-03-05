using SAGE.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace SAGE.Domain.Events
{
    public class NewEnderecoEventHandler : INotificationHandler<NewEnderecoEvent>
    {
        private readonly IEnderecoRepository _EnderecoRepository;
        public NewEnderecoEventHandler(IEnderecoRepository EnderecoRepository)
        {
            _EnderecoRepository = EnderecoRepository;
        }
        Task INotificationHandler<NewEnderecoEvent>.Handle(NewEnderecoEvent newEnderecoEvent, CancellationToken cancellationToken)
        {
            _EnderecoRepository.Add(newEnderecoEvent.Endereco);

            return Unit.Task;
        }
    }
}
