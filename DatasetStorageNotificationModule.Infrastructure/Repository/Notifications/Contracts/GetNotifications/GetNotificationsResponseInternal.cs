namespace DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.GetNotifications;

public record GetNotificationsResponseInternal(
    int Id,
    string Title,
    string Text
);
