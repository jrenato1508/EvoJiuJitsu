using EvoJiuJitsu.App.Configurations;
using EvoJiuJitsu.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do Identity
builder.Services.AddIdentityConfiguration(builder.Configuration);

builder.Services.AddDbContext<EvoDbcontext>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Configura��o AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//AddMvcConfig
builder.Services.AddMvcConfiguration();

// Configura��o DI
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Atleta}/{action=Index}/{id?}");

app.Run();
