using DashboardDaiNam.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ✅ Thêm dịch vụ MVC (controllers & views)
builder.Services.AddControllersWithViews();

// ✅ Thêm DbContext để kết nối SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Đăng ký IHttpContextAccessor để dùng HttpContext trong controller hoặc các service
builder.Services.AddHttpContextAccessor(); // ✅ THÊM DÒNG NÀY

// ✅ Cấu hình Session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session tồn tại 30 phút
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// ✅ Cấu hình HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Cho phép dùng CSS, JS, ảnh...

app.UseRouting();

app.UseSession(); // ✅ Quan trọng: phải đặt trước UseAuthorization

app.UseAuthorization();

// ✅ Cấu hình route mặc định: chuyển đến Dashboard
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();