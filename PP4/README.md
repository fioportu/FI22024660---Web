# Práctica Programada 4

- Nombre: Fiorella Portuguez Rojas
- Carné: FI22024660

## Objetivo:
- Aplicar conocimientos al utilizar Entity Framework usando Code First para leer archivos CSV y escritura de TSV.

## Comandos de Dotnet Utilizados

- dotnet new sln -n PP4
- dotnet new console -n PP4
- dotnet sln add PP4/PP4.csproj
- cd PP4
- mkdir data
- dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.0
- dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
- dotnet add package CsvHelper --version 30.0.1

## Páginas Web Utilizadas
Leer un archivo CSV y almacenar valores -- https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array

Guía paso a paso para leer archivos CSV en ASP.NET Core -- https://medium.com/@shekhartarare/step-by-step-guide-to-reading-csv-files-in-asp-net-core-08ee24729244


## Prompts DeekSeek

1. ¿Como puedo establecer el orden de columnas, por ejemplo en Title(TitleId, AuthorId, TitleName) con C# y con Entity Framework? 

2. ¿Como puedo crear un DbContext y apuntar hacia ./data/books.db? 

3. ¿Explicame cómo se reemplaza palabras /replace/{length} y qué pasa con mayúsculas/minúsculas o tildes?

Respuestas: https://chat.deepseek.com/share/l2qmse6ltyb1vf7lel

## Respuestas a las preguntas: 

1. ¿Cómo cree que resultaría el uso de la estrategia de Code First para crear y actualizar una base de datos de tipo NoSQL (como por ejemplo MongoDB)? ¿Y con Database First? ¿Cree que habría complicaciones con las Foreign Keys?

Me parece Database First esta diseñado para bases de datos relacionales, por lo que MongoDB es NoSQL sin tablas, sin esquemas fijos, no tiene foreign keys, por lo que considero que EF no encajaría bien y puede ocurrir problemas. 


2. ¿Cuál carácter, además de la coma (,) y el Tab (\t), se podría usar para separar valores en un archivo de texto con el objetivo de ser interpretado como una tabla (matriz)? ¿Qué extensión le pondría y por qué? Por ejemplo: Pipe (|) con extensión .pipe.

Una de las alternativas más comúnes es el punto y coma (;) porque evita conflictos donde la coma se usa como separador decimal, muchos archivos csv, excel, google sheets lo utilizan, además dependen de la configuración regional.