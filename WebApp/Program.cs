using Data.Contexts;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(@"Server=localhost,1433;Database=AlphaDB;User Id=sa;Password=CodeGuruOzzy2025!?;TrustServerCertificate=True")));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}")
    .WithStaticAssets();


app.Run();
