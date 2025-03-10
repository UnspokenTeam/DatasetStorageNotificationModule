using DatasetStorageNotificationModule.Infrastructure.Context;
using DatasetStorageNotificationModule.Infrastructure.Repository.Notifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DatasetStorageNotificationModule.Infrastructure;

public class InfrastructureInjection
{
    public static void Configure(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
                                                        options.UseNpgsql(Environment
                                                                              .GetEnvironmentVariable("ConnectionString")));

        services.AddScoped<INotificationsRepository, NotificationsRepository>();
    }
}
