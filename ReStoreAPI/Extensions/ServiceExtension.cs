using Microsoft.EntityFrameworkCore;
using ReStoreAPI.Data;

namespace ReStoreAPI.Extensions;

public static class ServiceExtension
{

    /// <summary>
    /// Extension Method to Add Configuration Services
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns>A reference to this object after the operation has completed</returns>
    public static IServiceCollection AddMetaServices(this IServiceCollection services, IConfiguration configuration)
    {
        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        string dbConnectionString;
        string jwtSecret;

        // Depending on if in development or production, use either Server-provided
        // connection string, or development connection string from env var.
        if (env == "Development")
        {
            // Use connection string from file.
            dbConnectionString = configuration.GetConnectionString("PostgreSQL");
            jwtSecret = configuration["JWT_SECRET"];
        }
        else
        {
            jwtSecret = Environment.GetEnvironmentVariable("JWT_SECRET")!;
            // Database
            // Use connection string provided at runtime.
            var connUrl = Environment.GetEnvironmentVariable("DATABASE_URL")!;
            var host = Environment.GetEnvironmentVariable("HostName");
            if (host == "Heroku") // Use Heroku Postgres
            {
                // Parse connection URL to connection string for Npgsql
                connUrl = connUrl.Replace("postgres://", string.Empty);
                var pgUserPass = connUrl.Split("@")[0];
                var pgHostPortDb = connUrl.Split("@")[1];
                var pgHostPort = pgHostPortDb.Split("/")[0];
                var pgDb = pgHostPortDb.Split("/")[1];
                var pgUser = pgUserPass.Split(":")[0];
                var pgPass = pgUserPass.Split(":")[1];
                var pgHost = pgHostPort.Split(":")[0];
                var pgPort = pgHostPort.Split(":")[1];

                dbConnectionString = $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb};sslmode=Prefer;Trust Server Certificate=true";
            }
            else // Use ElephantSQL Postgres
            {
                var uriString = connUrl;
                var uri = new Uri(uriString);
                var db = uri.AbsolutePath.Trim('/');
                var user = uri.UserInfo.Split(':')[0];
                var passwd = uri.UserInfo.Split(':')[1];
                var port = uri.Port > 0 ? uri.Port : 5432;
                dbConnectionString = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}", uri.Host, db, user, passwd, port);
            }
        }

        services.AddDbContext<StoreContext>(options =>
        {
            options.UseNpgsql(dbConnectionString);
        });

        return services;
    }
}
