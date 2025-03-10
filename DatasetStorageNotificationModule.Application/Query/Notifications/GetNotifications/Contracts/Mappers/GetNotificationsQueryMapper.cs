using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.GetNotifications;
using Riok.Mapperly.Abstractions;

namespace DatasetStorageNotificationModule.Application.Query.Notifications.GetNotifications.Contracts.Mappers;

[Mapper]
public static partial class GetNotificationsQueryMapper
{
    public static GetNotificationsQueryInternal ToInternal(GetNotificationsQuery request)
    {
        return new GetNotificationsQueryInternal(
                                                 request.Body.StartDate,
                                                 request.Body.EndDate,
                                                 request.Body.IsRead,
                                                 request.Body.Ids,
                                                 request.Body.TaskIds
                                                );
    }

    public static partial GetNotificationsQueryResponse FromInternal(GetNotificationsResponseInternal response);
}
