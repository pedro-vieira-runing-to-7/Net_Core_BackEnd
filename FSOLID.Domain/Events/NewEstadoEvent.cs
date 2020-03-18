using FSOLID.Commom.Publisher;
using FSOLID.Domain.Entities;

namespace FSOLID.Domain.Events
{
    public class NewEstadoEvent : Event
    {
        public NewEstadoEvent(Estado newEstado)
        {
            Estado = newEstado;
        }
        public Estado Estado { get; set; }
    }
}
