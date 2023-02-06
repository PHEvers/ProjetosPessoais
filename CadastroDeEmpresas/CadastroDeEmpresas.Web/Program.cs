using Microsoft.EntityFrameworkCore;
using CadastroDeEmpresas.Domain.IRepositories;
using CadastroDeEmpresas.Domain.IRrepositories;
using CadastroDeEmpresas.Domain.IService;
using CadastroDeEmpresas.Infra.Data.Repositories;
using CadastroDeEmpresas.Infra.Data.Context;
using CadastroDeEmpresas.Application.Service.SQLServerServices;
using CadastroDeFornecedors.Application.Service.SQLServerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context SQL Server
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer("Server=PCDOPH\\SQLEXPRESS;Database=CadastroEmpresa;User Id=sa;Password=admin;TrustServerCertificate=True;Encrypt=False;"));

// ### Dependency Injection
// # Repositories
builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IUFRepository, UFRepository>();

// # Services
builder.Services.AddScoped<IEmpresaService, EmpresaService>();
builder.Services.AddScoped<IFornecedorService, FornecedorService>();
builder.Services.AddScoped<IUFService, UFService>();
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();