using Desafio.Nibo.Business.Notifications;
using System.Collections.Generic;

namespace Desafio.Nibo.Business.Interfaces
{
    public interface INotifier
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
