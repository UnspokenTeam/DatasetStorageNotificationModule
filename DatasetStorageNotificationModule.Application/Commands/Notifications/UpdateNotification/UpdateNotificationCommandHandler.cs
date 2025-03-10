using DatasetStorageNotificationModule.Application.Commands.Notifications.UpdateNotification.Contracts;
using DatasetStorageNotificationModule.Application.Commands.Notifications.UpdateNotification.Contracts.Mappers;
using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications;
using MediatR;

namespace DatasetStorageNotificationModule.Application.Commands.Notifications.UpdateNotification;

public class UpdateNotificationCommandHandler(
    INotificationsRepository notificationsRepository
) : IRequestHandler<UpdateNotificationCommand, UpdateNotificationCommandResponse>
{
    public async Task<UpdateNotificationCommandResponse> Handle(UpdateNotificationCommand request,
                                                                CancellationToken cancellationToken)
    {
        await notificationsRepository
            .UpdateNotificationsAsync(UpdateNotificationsCommandMapper.ToInternal(request.Body), cancellationToken);
        return new UpdateNotificationCommandResponse();
    }
}
