using MediatR;

namespace FSOLID.Commom.Publisher
{
    public abstract class Event : Message, INotification
    {
    }
}
