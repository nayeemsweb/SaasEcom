using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Ecommerce.Membership;
using Ecommerce.Membership.DbContexts;
using Ecommerce.Membership.Entities;
using Ecommerce.Membership.Security;
using Ecommerce.Membership.Services;
using Ecommerce.Store;
using Ecommerce.Store.DbContexts;
using Ecommerce.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);
//builder.WebHost.UseUrls("https://127.0.0.1:7190");

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var assemblyName = Assembly.GetExecutingAssembly().FullName;

// Autofac configuration
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new WebModule());
    containerBuilder.RegisterModule(new MembershipModule(connectionString, assemblyName));
    containerBuilder.RegisterModule(new StoreModule(connectionString, assemblyName));
});

// Serilog configuration
builder.Host.UseSerilog((ctx, lc) => lc
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .ReadFrom.Configuration(builder.Configuration));

// automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, m => m.MigrationsAssembly(assemblyName)));

builder.Services.AddDbContext<StoreDbContext>(options =>
    options.UseSqlServer(connectionString, m => m.MigrationsAssembly(assemblyName)));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddControllersWithViews();

//for one to many and many to many json nested level data reading purposes
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddSingleton<IAuthorizationHandler, TestRequirementHandler>();

builder.Services
    .AddIdentity<ApplicationUser, Role>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddUserManager<UserManager>()
    .AddRoleManager<RoleManager>()
    .AddSignInManager<SignInManager>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MerchantPolicy", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireRole("Vendor");
        policy.RequireRole("Distributor");
    });

    options.AddPolicy("TestViewPolicy", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("ViewTestPage", "true");
    });

    options.AddPolicy("TestRequirementPolicy", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.Requirements.Add(new TestRequirement());
    });
});

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(7);
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.SlidingExpiration = true;
});

try
{
    var app = builder.Build();

    Log.Information("Application Starting up");


    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseMigrationsEndPoint();
    }
    else
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


    //routes
    app.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    app.MapRazorPages();

    app.Run();

}
catch (Exception ex)
{
    Log.Fatal(ex, "Application start-up failed");
}
finally
{
    Log.CloseAndFlush();
}