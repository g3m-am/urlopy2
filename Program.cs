using Microsoft.EntityFrameworkCore;

using urlopy2.Models;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddTransient<DataSeeder>();

// Add services to the container.
//builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer());
// problemy do 2.1 pomoglo patrz install/textfile.txt
builder.Services.AddDbContext<AppDbContext>(options =>
{
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});




builder.Services.AddControllersWithViews();

//ilder.Services.AddTransient<IPracownikRepository, MockPracownikRepository>();
builder.Services.AddTransient<IPracownikRepository, PracownikRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
