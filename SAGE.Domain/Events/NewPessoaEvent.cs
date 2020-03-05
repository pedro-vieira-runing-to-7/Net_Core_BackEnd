using SAGE.Commom.Publisher;
using SAGE.Domain.Entities;

namespace SAGE.Domain.Events
{
    public class NewPessoaEvent : Event
    {
        public NewPessoaEvent(Pessoa newPessoa)
        {
            Pessoa = newPessoa;
        }
        public Pessoa Pessoa { get; set; }
    }
}
