using Microsoft.EntityFrameworkCore;
using ReStoreAPI.Data;

namespace ReStoreAPI.Extensions;

public static class SeedDbExtension
{
    public static void SeedDb(this WebApplication app)
    {

        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<StoreContext>();
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        try
        {
            context.Database.Migrate();
            DbInitialzer.Initialize(context);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Problem migrating data");
        }
    }
}
