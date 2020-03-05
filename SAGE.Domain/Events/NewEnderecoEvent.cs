using SAGE.Commom.Publisher;
using SAGE.Domain.Entities;

namespace SAGE.Domain.Events
{
    public class NewEnderecoEvent : Event
    {
        public NewEnderecoEvent(Endereco newEndereco)
        {
            Endereco = newEndereco;
        }
        public Endereco Endereco { get; set; }
    }
}
