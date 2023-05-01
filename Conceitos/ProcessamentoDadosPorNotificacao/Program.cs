using Configuracoes.Extensions;
using Microsoft.AspNetCore.Builder;
using ProcessamentoDadosPorNotificacao.Configuracoes.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDependenciasNegocio();
builder.AddOpenAPI(); //Swagger Extensions

var app = builder.Build();
app.UseRouting();
app.MapControllers();
app.UseOpenSwagger();
app.Run();