var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(options=>options.RootDirectory="/pages");

var app=builder.Build();

app.MapRazorPages();

app.Run();
