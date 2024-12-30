var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("api/hello", (HttpContext content) => "Hello World!" + $"{content.Request.Scheme}://{content.Request.Host.Value}/");

app.Run();
