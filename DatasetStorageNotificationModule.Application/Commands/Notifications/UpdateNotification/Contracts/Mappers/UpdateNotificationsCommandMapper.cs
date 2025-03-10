using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.UpdateNotifications;
using Riok.Mapperly.Abstractions;

namespace DatasetStorageNotificationModule.Application.Commands.Notifications.UpdateNotification.Contracts.Mappers;

[Mapper]
public static partial class UpdateNotificationsCommandMapper
{
    public static partial UpdateNotificationsCommandInternal ToInternal(UpdateNotificationCommandBody request);
}
