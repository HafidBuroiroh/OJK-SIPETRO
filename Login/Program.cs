var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(name: "Home",
                pattern: "home/{*index}",
                defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(name: "Transfer_Data",
                pattern: "transfer/{*index}",
                defaults: new { controller = "Transfer", action = "Index" });

app.MapControllerRoute(name: "Generate_Data",
                pattern: "generate/{*index}",
                defaults: new { controller = "Generate", action = "Index" });

app.MapControllerRoute(name: "Send_Data",
                pattern: "send/{*index}",
                defaults: new { controller = "Send", action = "Index" });

app.MapControllerRoute(name: "default",
               pattern: "{controller=Login}/{action=Login}/{id?}");


app.Run();
