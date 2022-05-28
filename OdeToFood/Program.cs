using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.AddDbContext<OdeToFoodDbContext>(options =>

    options.UseSqlServer("name=ConnectionStrings:OdeToFoodDb"));

builder.Services.AddScoped<IRestaurantData, SqlRestaurantData>();

//builder.Services.AddScoped<IRestaurantData, InMemoryRestaurantData>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(e =>
{
    e.MapRazorPages();
    e.MapControllers();
});

app.UseAuthorization();
app.UseNodeModules();

app.MapRazorPages();

app.Run();

