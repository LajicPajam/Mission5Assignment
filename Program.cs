var builder = WebApplication.CreateBuilder(args);

// Register MVC so controllers can render Razor views.
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // In production, show a friendly error page and enforce HTTPS.
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Core middleware pipeline for routing and auth.
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

// Serve static files and map the default route (Home/Index).
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
