namespace DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.GetNotifications;

public record GetNotificationsQueryInternal(
    DateTime? StartDate,
    DateTime? EndDate,
    bool? IsRead,
    List<int>? Ids,
    List<int>? TaskIds
);
