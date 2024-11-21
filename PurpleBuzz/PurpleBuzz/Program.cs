using Microsoft.EntityFrameworkCore;
using PurpleBuzz.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});



var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
          name: "areas",
          pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
        );


app.MapControllerRoute
(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );
app.Run();
