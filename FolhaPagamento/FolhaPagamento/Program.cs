using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();


app.MapGet("api/funcionario/listar",([FromServices] AppDataContext ctx)=>{
    return Results.Ok(ctx.TabelaFuncionario.ToList());
});

app.MapPost("api/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDataContext ctx) => {
    ctx.TabelaFuncionario.Add(funcionario);
    ctx.SaveChanges();  

    return Results.Created("", funcionario);
});

app.MapPost("api/folha/cadastrar", ([FromBody] Folha folha, [FromServices] AppDataContext ctx) => {
    ctx.TabelaFolha.Add(folha);
    ctx.SaveChanges();
    folha.calculoSalario();

    return Results.Ok(folha);
});

app.MapPost("api/folha/listar", ([FromServices] AppDataContext ctx) => {
    if(ctx.TabelaFolha is null){
        return Results.NotFound("Holerites indisponiveis!");
    }

    return Results.Ok(ctx.TabelaFolha.Include(folha => folha.Id).ToList());
});

app.MapGet("api/folha/buscar/{mes}/{ano}", ([FromRoute] int mes,[FromRoute] int ano, [FromServices] AppDataContext ctx) => {
    Folha? folha = ctx.TabelaFolha.FirstOrDefault(x=>x.mes == mes);
    
    if(folha is null){
        return Results.NotFound("Folha nao encontrado!");
    }

    return Results.Ok(folha);
});

app.Run();
