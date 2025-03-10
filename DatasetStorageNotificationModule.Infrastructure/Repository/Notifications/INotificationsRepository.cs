using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.GetNotifications;
using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.UpdateNotifications;

namespace DatasetStorageNotificationModule.Infrastructure.Repository.Notifications;

public interface INotificationsRepository
{
    public Task<List<GetNotificationsResponseInternal>> GetNotificationsAsync(
        GetNotificationsQueryInternal request, CancellationToken cancellationToken);

    public Task UpdateNotificationsAsync(UpdateNotificationsCommandInternal request,
                                         CancellationToken cancellationToken);
}
