using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EntityTesting.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EntityTestingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EntityTestingContext") ?? throw new InvalidOperationException("Connection string 'EntityTestingContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
