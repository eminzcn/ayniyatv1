using ayniyatv1.Data;
using ayniyatv1.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddTransient<AppDbInitializer>();
builder.Services.AddDbContext<AppDbContext>(x =>  x.UseSqlServer(connectionString).EnableDetailedErrors());
builder.Services.AddScoped<IUrunService, UrunService>();
builder.Services.AddScoped<IPersonelService, PersonelService>();
var app = builder.Build();


if (args.Length == 1 && args[0].ToLower() == "seeddata")
{
    SeedData(app);
}

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<AppDbInitializer>();
        service.Seed();
    }
}


// Seed DataBase
// AppDbInitializer.Seed(app);

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
    pattern: "{controller=Personel}/{action=Index}/{id?}");



app.Run();


