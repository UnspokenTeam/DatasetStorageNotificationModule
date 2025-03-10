using DatasetStorageNotificationModule.Application.Commands.Notifications.UpdateNotification.Contracts;
using DatasetStorageNotificationModule.Application.Query.Notifications.GetNotifications.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DatasetStorageNotificationModule.Controllers;

[ApiController]
[Route("notifications")]
public class NotificationController(
    IMediator mediator
) : ControllerBase
{
    [HttpGet]
    public async Task<GetNotificationsQueryResponseList> GetNotifications([FromQuery] GetNotificationsQueryBody request)
    {
        return await mediator.Send(new GetNotificationsQuery(request));
    }

    [HttpPost]
    public async Task<UpdateNotificationCommandResponse> UpdateNotifications(UpdateNotificationCommandBody request)
    {
        return await mediator.Send(new UpdateNotificationCommand(request));
    }
}
