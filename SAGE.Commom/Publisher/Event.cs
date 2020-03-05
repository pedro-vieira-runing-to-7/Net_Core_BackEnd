using MediatR;

namespace SAGE.Commom.Publisher
{
    public abstract class Event : Message, INotification
    {
    }
}
