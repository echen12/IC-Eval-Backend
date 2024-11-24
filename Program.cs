var builder = WebApplication.CreateBuilder(args);

// Allow cors for dev purposes
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()  // This will allow requests from any origin
            .AllowAnyMethod()    // Allow any HTTP method (GET, POST, etc.)
            .AllowAnyHeader();   // Allow any HTTP header
    });
});

var app = builder.Build();


app.UseCors();
app.UseRouting();  
app.MapGet("/data", async () =>
{
    var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "StaticFiles", "data.json");
    var jsonData = await File.ReadAllTextAsync(jsonFilePath);
    return Results.Text(jsonData, "application/json");
});


app.Run();