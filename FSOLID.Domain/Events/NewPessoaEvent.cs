using FSOLID.Commom.Publisher;
using FSOLID.Domain.Entities;

namespace FSOLID.Domain.Events
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
