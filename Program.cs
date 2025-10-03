var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();  

DbContextInitializer.InitializeDbContext(builder.Services);

using var scope = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var appDbContext = scope .ServiceProvider
}

app.MapGet("/", () => "Hello World!");

app.Run();
