namespace DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.UpdateNotifications;

public record UpdateNotificationsCommandInternal(
    List<int> Ids,
    bool IsRead
);
