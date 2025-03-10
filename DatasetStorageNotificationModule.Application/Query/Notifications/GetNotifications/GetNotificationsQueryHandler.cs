using DatasetStorageNotificationModule.Application.Query.Notifications.GetNotifications.Contracts;
using DatasetStorageNotificationModule.Application.Query.Notifications.GetNotifications.Contracts.Mappers;
using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications;
using MediatR;

namespace DatasetStorageNotificationModule.Application.Query.Notifications.GetNotifications;

public class GetNotificationsQueryHandler(
    INotificationsRepository notificationsRepository
) : IRequestHandler<GetNotificationsQuery, GetNotificationsQueryResponseList>
{
    public async Task<GetNotificationsQueryResponseList> Handle(GetNotificationsQuery request,
                                                                CancellationToken cancellationToken)
    {
        var notifications =
            await notificationsRepository.GetNotificationsAsync(GetNotificationsQueryMapper.ToInternal(request),
                                                                cancellationToken);
        return new GetNotificationsQueryResponseList(notifications
                                                     .Select(GetNotificationsQueryMapper.FromInternal)
                                                     .ToList());
    }
}
