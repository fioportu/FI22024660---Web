
//ERRORES: Agregar los usings
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Antiforgery;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var list = new List<object>();
var random  = new Random();

app.MapGet("/", () => Results.Redirect("/swagger"));

//UPDATE: Post con header
//https://chat.deepseek.com/share/ou5pv6ti07d8ni9tmy
app.MapPost("/", ([FromHeader(Name = "xml")] bool? xml) =>
{
    var wantsXml = xml is true;

    if (!wantsXml)
    { return Results.Ok(list); }
    
    var sb = new System.Text.StringBuilder();
    sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
    sb.Append("<Items>");
    foreach (var item in list)
    {
        if (item is int i)
            sb.Append($"<Item type=\"int\">{i}</Item>");
        else if (item is double d)
            sb.Append($"<Item type=\"float\">{d}</Item>");
        else
            sb.Append($"<Item type=\"unknown\">{System.Security.SecurityElement.Escape(item?.ToString() ?? string.Empty)}</Item>");
    }
    sb.Append("</Items>");

    return Results.Text(sb.ToString(), "application/xml");
});


app.MapPut("/", ([FromForm] int? quantity, [FromForm] string? type) =>
{
    // IMPROVEMENT: validar quantity > 0
    if (quantity is null || quantity <= 0)
        return Results.Json(new { error = "'quantity' must be higher than zero" }, statusCode: 400);

    // IMPROVEMENT: validar tipo
    if (string.IsNullOrWhiteSpace(type))
        return Results.Json(new { error = "'type' is required and must be 'int' or 'float'" }, statusCode: 400);

    var t = type.Trim().ToLowerInvariant();
    if (t != "int" && t != "float")
        return Results.Json(new { error = "'type' must be either 'int' or 'float'" }, statusCode: 400);

    for (int i = 0; i < quantity.Value; i++)
    {
        if (t == "int")
            list.Add(random.Next());        // entero
        else
            list.Add(random.NextSingle());  // flotante
    }
    return Results.Ok(list);
})
 .DisableAntiforgery()
;

app.MapDelete("/", ([FromForm] int? quantity) =>
{
    // IMPROVEMENT: validar quantity > 0
    if (quantity is null || quantity <= 0)
        return Results.Json(new { error = "'quantity' must be higher than zero" }, statusCode: 400);

    // IMPROVEMENT: verificar que existan al menos 'quantity' elementos
    if (quantity.Value > list.Count)
        return Results.Json(new { error = "'quantity' exceeds current list size" }, statusCode: 400);

    list.RemoveRange(0, quantity.Value);

    return Results.Ok(list);
})
 .DisableAntiforgery()
;

//UPDATE: Patch limpia la lista
//https://chat.deepseek.com/share/ou5pv6ti07d8ni9tmy
app.MapPatch("/", () =>
{
   list.Clear();
    return Results.Ok(list);
});

app.Run();
