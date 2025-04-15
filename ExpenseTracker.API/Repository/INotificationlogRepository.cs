using System;
using Models;
namespace Repository{
    public interface INotificationLogRepository{
        bool AddNotification (NotificationLog notificationlogdata);
        bool UpdateNotification (NotificationLog notificationlogdata);
        bool DeleteNotification (string NotificationId);
        IList<NotificationLog> GetNotifications();
        NotificationLog GetNotificationLog(string NotificationId);
    }
}