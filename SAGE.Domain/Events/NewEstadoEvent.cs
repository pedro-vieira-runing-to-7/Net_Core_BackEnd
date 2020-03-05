using SAGE.Commom.Publisher;
using SAGE.Domain.Entities;

namespace SAGE.Domain.Events
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
