using CarFlow.Core.IRepository;
using CarFlow.DomainServices.IService;
using CarFlow.DomainServices.Services;
using CarFlow.Infrastructure.Models;
using CarFlow.Infrastructure.Repositories;
using CarFlow.UI.CustomBinders;
using CarFlow.UI.Interfaces;
using CarFlow.UI.Managers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// AddAsync services to the container.

builder.Services.AddDbContext<CarFlowContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnection") ?? throw new InvalidOperationException("Connection string 'SQLConnection' not found.")));
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews(options =>
{
    options.ModelBinderProviders.Insert(0, new CarModelBinderProvider());
});

builder.Services.AddRazorPages();

// Repositories
builder.Services.AddScoped<IRegionRepository, RegionRepository>();
builder.Services.AddScoped<ITransmissionRepository, TransmissionRepository>();
builder.Services.AddScoped<IDrivetrainRepository, DrivetrainRepository>();
builder.Services.AddScoped<IMakeRepository, MakeRepository>();
builder.Services.AddScoped<IEngineRepository, EngineRepository>();
builder.Services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
builder.Services.AddScoped<IEngineConfigurationRepository, EngineConfigurationRepository>();
builder.Services.AddScoped<IEngineAspirationRepository, EngineAspirationRepository>();
builder.Services.AddScoped<IAccountRepositоry, AccountRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<ICarRepository, CarRepository>();

// Services
builder.Services.AddScoped<IPasswordHasherService, PasswordHasherService>();
builder.Services.AddScoped<IRegionService, RegionService>();
builder.Services.AddScoped<ITransmissionService, TransmissionService>();
builder.Services.AddScoped<IDrivetrainService, DrivetrainService>();
builder.Services.AddScoped<IMakeService, MakeService>();
builder.Services.AddScoped<IEngineService, EngineService>();
builder.Services.AddScoped<IFuelTypeService, FuelTypeService>();
builder.Services.AddScoped<IEngineConfigurationService, EngineConfigurationService>();
builder.Services.AddScoped<IEngineAspirationService, EngineAspirationService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ICarOptionsManager, CarOptionsManager>();
builder.Services.AddScoped<IEngineOptionsManager, EngineOptionsManager>();

// Authentication services
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/Account/SignIn";
        option.LogoutPath = "/Account/SignOut";
    });

builder.Services.AddAuthorization(option =>
{
    option.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
    option.AddPolicy("ManagerPolicy", policy => policy.RequireRole("Manager"));
    option.AddPolicy("User", policy => policy.RequireRole("User"));
});


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
