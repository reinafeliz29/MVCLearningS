using Microsoft.EntityFrameworkCore;
using MVCDemoS.Data;
using MVCDemoS.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddApplicationService(builder.Configuration);
builder.Services.AddDbContext<ApplicationConnectDb>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection1")
    ));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//Today I tried deploy webservice kubernetes, successfully create pods, get a ImagePullBackOff error by creating pods, go through some references for the error. 

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
