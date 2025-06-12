using ChirpyCsharp.Web.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
app.UseStaticFiles();

app.UseMiddleware<RequestLoggingMiddleware>();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.MapGet("/swagger/openapi.yaml", async context =>
    {
        context.Response.ContentType = "application/yaml";
        await context.Response.SendFileAsync("wwwroot/swagger/openapi.yaml");
    });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/openapi.yaml", "API v1");
        options.RoutePrefix = "docs"; // Swagger UI will be at /docs
    });
}

app.Run();

public partial class Program { }