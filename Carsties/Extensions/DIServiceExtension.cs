using Carsties.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Carsties.Api.Extensions
{
    public static class DIServiceExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            // Register DbContext
            services.AddDbContext<CarstiesDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            using CarstiesDbContext Context =
                scope.ServiceProvider.GetRequiredService<CarstiesDbContext>();

            try
            {
                Context.Database.Migrate();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it in some way
                // For example, you could write it to a log file or display a user-friendly error message
                Console.WriteLine($"An error occurred while applying migrations: {ex.Message}");
            }
        }
    }
}
