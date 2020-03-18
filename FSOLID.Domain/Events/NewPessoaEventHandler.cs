using FSOLID.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FSOLID.Domain.Events
{
    public class NewPessoaEventHandler : INotificationHandler<NewPessoaEvent>
    {
        private readonly IPessoaRepository _PessoaRepository;
        public NewPessoaEventHandler(IPessoaRepository PessoaRepository)
        {
            _PessoaRepository = PessoaRepository;
        }
        Task INotificationHandler<NewPessoaEvent>.Handle(NewPessoaEvent newPessoaEvent, CancellationToken cancellationToken)
        {
            _PessoaRepository.Add(newPessoaEvent.Pessoa);

            return Unit.Task;
        }
    }
}
