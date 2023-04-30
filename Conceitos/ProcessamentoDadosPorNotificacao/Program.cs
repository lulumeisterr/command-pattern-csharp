using Microsoft.AspNetCore.Builder;
using ProcessamentoDadosPorNotificacao.Configuracoes.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDependenciasNegocio();

var app = builder.Build();
app.UseRouting();
app.MapControllers();
app.Run();