using Microsoft.EntityFrameworkCore;
using Сsharp_Clicker.Infastructure.Implementations;

namespace Сsharp_Clicker.Infrastructure.Initialization
{
    public static class DbContextInitializer
    {
        public static void InitializeDbContext(IServiceCollection services)
        =>
            services.AddDbContext<AppDbContext>(o => o.UseSqlite($"Data Source="));
        

        public static void InitializeDataBase(AppDbContext db)
        {

        }

        public static string GetPathToDatabaseFile()
        {
            var pathToApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var dbFilePath = Path.Combine(pathToLocalApplicationData, "CSharp")
        }
    }
}
