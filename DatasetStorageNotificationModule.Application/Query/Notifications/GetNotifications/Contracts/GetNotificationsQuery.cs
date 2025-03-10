using MediatR;

namespace DatasetStorageNotificationModule.Application.Query.Notifications.GetNotifications.Contracts;

public record GetNotificationsQueryBody(
    DateTime? StartDate,
    DateTime? EndDate,
    bool? IsRead,
    List<int>? Ids,
    List<int>? TaskIds
);

public record GetNotificationsQuery(
    GetNotificationsQueryBody Body
) : IRequest<GetNotificationsQueryResponseList>;
