using MediatR;

namespace DatasetStorageNotificationModule.Application.Commands.Notifications.UpdateNotification.Contracts;

public record UpdateNotificationCommandBody(
    List<int> Ids,
    bool IsRead
);

public record UpdateNotificationCommand(
    UpdateNotificationCommandBody Body
) : IRequest<UpdateNotificationCommandResponse>;
