namespace DatasetStorageNotificationModule.Application.Query.Notifications.GetNotifications.Contracts;

public record GetNotificationsQueryResponse(
    int Id,
    string Title,
    string Text
);

public record GetNotificationsQueryResponseList(
    List<GetNotificationsQueryResponse> Notifications
);
