using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Data;

var builder = WebApplication.CreateBuilder(args);

// Servisleri ekle
builder.Services.AddControllersWithViews();

// Veritabanı bağlantısı
builder.Services.AddDbContext<UygulamaDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// !!! İŞTE BU KISIM EKSİK OLABİLİR !!!
// Uygulama her başladığında veritabanı yoksa oluşturur ve günceller.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<UygulamaDbContext>();
    context.Database.Migrate(); // Bu komut veritabanını ve tabloları oluşturur
}
// !!! BURAYA KADAR !!!

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
