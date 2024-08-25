using BlazorLearning.Components;
using BlazorLearning.DAL;
using BlazorLearning.Services;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionStr = builder.Configuration.GetSection("ConnectionStrings").GetSection("ProdConnection");
builder.Services.AddDbContext<BlazorLearningDbContext>(options =>options.UseSqlServer(connectionStr.Value));
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddTransient<IGetCount, MasterInventoryManagement>();
builder.Services.AddTransient<ISearchMasterItem, SearchPartFromMasterInventory>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
