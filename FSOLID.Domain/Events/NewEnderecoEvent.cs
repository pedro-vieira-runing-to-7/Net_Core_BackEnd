using FSOLID.Commom.Publisher;
using FSOLID.Domain.Entities;

namespace FSOLID.Domain.Events
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
