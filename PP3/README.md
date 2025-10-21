# Práctica Programada 3

- Nombre: Fiorella Portuguez Rojas
- Carné: FI22024660

## Objetivo:
- Aplicar conocimientos al utilizar Minimal API con la herramienta ASP.NET Core Minimal API.

## Comandos de Dotnet Utilizados

- mkdir PP3; cd PP3
- dotnet new sln -n PP3
- dotnet new web -n PP3 -f net8.0
- dotnet sln add PP3/PP3.csproj

## Páginas Web Utilizadas
Tutorial: Create a minimal API with ASP.NET Core -- https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-9.0&tabs=visual-studio

Como crear respuestas en aplicaciones de API -- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/responses?view=aspnetcore-9.0

Documentación de la API web de ASP.NET Core con Swagger/OpenAPI -- https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-8.0

API mínimas: Parámetros de IFormFile requieren comprobaciones antifalsificación -- https://learn.microsoft.com/en-us/dotnet/core/compatibility/aspnet-core/8.0/antiforgery-checks

## Prompts Chat GPT

1. En ASP.NET Core, para minimal api ¿Qué hace cada endpoint: /, /include, /replace, /erase?

2. ¿Explicame cómo funciona la inserción en /include/{position} cuando position es mayor al número de palabras?

3. ¿Explicame cómo se reemplaza palabras /replace/{length} y qué pasa con mayúsculas/minúsculas o tildes?

Respuestas: https://chatgpt.com/share/68f80653-858c-8000-ab59-2ca2f9d7a287

## Respuestas a las preguntas: 

1. ¿Es posible enviar valores en el Body (por ejemplo, en el Form) del Request de tipo GET?

Me parece que sí se puede, pero no es la mejor opción. Para GET es mejor utilizar una consulta (query) en la URL, según las prácticas de HTTP. Por lo tanto usar el Query en Get, y para enviar datos usa POST/PUT.


2. ¿Qué ventajas y desventajas observa con el Minimal API si se compara con la opción de utilizar Controllers?

Usar Minimal API me pareció sencillo, tiene menos código y es fácil de probar, pero no lleva muy buena estructura a mi punto de vista, sirve para proyectos pequeños, así que en proyectos grandes y complejos sería mejor utilizar Controllers, aunque me parece que tiene un código más complejo, sus ventajas podrían ser que tiene una estructura más clara, son más escalables y organizan mejor el proyecto.