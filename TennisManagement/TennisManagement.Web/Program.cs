using Microsoft.EntityFrameworkCore;
using TennisManagement.Services.Core.Contracts.Matches;
using TennisManagement.Services.Core.Contracts.Roster;
using TennisManagement.Data.Persistance;
using TennisManagement.Services.Core.Services.Matches;
using TennisManagement.Services.Core.Services.Roster;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(cfg =>
    cfg.AddMaps(typeof(SQLMatchService).Assembly));

builder.Services.AddScoped<IMatchService, SQLMatchService>();
builder.Services.AddScoped<IPlayerService, SQLPlayerService>();

string? connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException("Connection string " +
        "'DefaultConnection' was not found or is empty " +
        "in configuration.");
}

builder.Services.AddDbContext<TennisManagementDbContext>(options =>
    options.UseSqlServer(connectionString));

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
