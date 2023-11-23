using Blazor8CRUD.Components;
using Blazor8CRUD.DbModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContextFactory<MyDbcontext>((service, option) =>
{
    var conf = service.GetRequiredService<IConfiguration>();
    string ConnectionString = conf.GetConnectionString("MyDB");
    option.UseSqlServer(ConnectionString);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
