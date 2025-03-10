using DatasetStorageNotificationModule.Infrastructure.Context;
using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.GetNotifications;
using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications.Contracts.UpdateNotifications;
using Microsoft.EntityFrameworkCore;

namespace DatasetStorageNotificationModule.Infrastructure.Repository.Notifications;

public class NotificationsRepository(
    ApplicationDbContext dbContext
) : INotificationsRepository
{
    public async Task<List<GetNotificationsResponseInternal>> GetNotificationsAsync(
        GetNotificationsQueryInternal request, CancellationToken cancellationToken)
    {
        return await dbContext.Database.SqlQuery<GetNotificationsResponseInternal>($@"
        SELECT 
            id AS Id,
            title AS Title,
            details AS Text
        FROM notifications
        WHERE 1=1 AND
            ({!request.StartDate.HasValue} OR created_at >= {request.StartDate}) AND
            ({!request.EndDate.HasValue} OR created_at <= {request.EndDate}) AND
            ({request.Ids == null || request.Ids.Count == 0} OR id = ANY({request.Ids ?? []})) AND
            ({!request.IsRead.HasValue} OR is_read = {request.IsRead.GetValueOrDefault(false)})
        ORDER BY created_at DESC
    ")
                              .ToListAsync(cancellationToken);
    }

    public async Task UpdateNotificationsAsync(UpdateNotificationsCommandInternal request,
                                               CancellationToken cancellationToken)
    {
        await dbContext.Database.ExecuteSqlAsync($@"
        UPDATE notifications
        SET 
            is_read = {request.IsRead}, 
            updated_at = now()
        WHERE id = ANY({request.Ids})
    ", cancellationToken);
    }
}
