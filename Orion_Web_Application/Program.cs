using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Orion_Web_Application.Areas.Identity;
using Orion_Web_Application.Data;
using SqlDataAccessLibrary;
using SqlDataAccessLibrary.Data;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();

//My Services
builder.Services.AddMudServices();
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IStudentsData, StudentsData>();
builder.Services.AddTransient<ISubdivisionData, SubdivisionData>();
builder.Services.AddTransient<IEmployeeData, EmployeeData>();
builder.Services.AddTransient<IMainGroupsTableData, MainGroupsTableData>();
builder.Services.AddTransient<IGroupData, GroupData>();



// Server Side Blazor doesn't register HttpClient by default
// Нужно для работы MatBlazor
if (!builder.Services.Any(x => x.ServiceType == typeof(HttpClient)))
{
    // Setup HttpClient for server side in a client side compatible fashion
    builder.Services.AddScoped<HttpClient>(s =>
    {
        // Creating the URI helper needs to wait until the JS Runtime is initialized, so defer it.
        var uriHelper = s.GetRequiredService<NavigationManager>();
        return new HttpClient
        {
            BaseAddress = new Uri(uriHelper.BaseUri)
        };
    });
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();