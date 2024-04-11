using EvoJiuJitsu.App.Configurations;
using EvoJiuJitsu.App.Data;
using EvoJiuJitsu.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

builder.Services.AddDbContext<EvoDbcontext>(Options =>
    Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


#region Configuração do Identity
// Configuracao do Identity
//builder.Services.AddIdentityConfiguration(builder.Configuration);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                                            options.UseSqlServer("DefaultConnection"));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddEntityFrameworkStores<ApplicationDbContext>();
#endregion

//Configuracao AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//AddMvcConfig
builder.Services.AddMvcConfiguration();

// Configuracao DI
builder.Services.ResolveDependecies();


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
app.UseAuthentication();;
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Atleta}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
