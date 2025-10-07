# Calculadora Binaria

Proyecto para realizar operaciones binarias.

- Nombre: Fiorella Portuguez Rojas
- Carné: FI22024660

## Funcionalidades
- Validación de cadenas binarias (solo 0 y 1, múltiplo de 2, máximo 8 caracteres).
- Operaciones binarias:
  - AND
  - OR
  - XOR
- Operaciones aritméticas:
  - Suma
  - Multiplicación
- Conversión de bases:
  - Binario
  - Octal
  - Decimal
  - Hexadecimal

## Comandos de Dotnet Utilizados

- dotnet new sln -n BinCalc
- dotnet new mvc -n BinCalc -f net8.0 --no-https
- dotnet sln add BinCalc/BinCalc.csproj
- cd BinCalc
- dotnet run

## Páginas Web Utilizadas
Bitwise and shift operators ( C# Reference) -- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

Como manipular bits de una cadena binaria en C# -- https://stackoverflow.com/questions/58567975/how-to-manipulate-bits-of-a-binary-string-in-c-sharp?

Validación con los validadores de anotación de datos C# -- https://learn.microsoft.com/es-es/aspnet/mvc/overview/older-versions-1/models-data/validation-with-the-data-annotation-validators-cs

## Prompts Chat GPT

1.Explícame con un ejemplo cómo convertir un número binario a octal, decimal y hexadecimal en C#

- Respuesta: https://chatgpt.com/share/68e484d4-ac98-8000-946c-abd5f72984c4

2. Muestrame una tabla sencilla comparando las operaciones AND, OR, XOR con ejemplos de binarios.
- Respuesta: https://chatgpt.com/share/68e4865f-4414-8000-bf9f-bdc85a56d31c

3. Muéstrame una vista en Razor que tenga un formulario con dos inputs y un botón.

- Respuesta: https://chatgpt.com/share/68e486c0-8aa4-8000-ba31-2721d619ecc0

## Respuestas a las preguntas: 

1. ¿Cuál es el número que resulta al multiplicar, si se introducen los valores máximos permitidos en a y b? Indíquelo en todas las bases (binaria, octal, decimal y hexadecimal).

Los valores máximos permitidos para a y b son 11111111 ( 8 bits) 255 * 255 = 65025

- Binario: 1111111000000001
- Octal: 177401
- Decimal: 65025
- Hexadecimal: FE01

2. ¿Es posible hacer las operaciones en otra capa? Si sí, ¿en cuál sería?

Se pueden realizar en la capa de Servicios (Services Layer), permite separar la lógica de negocio, ayudando a tener un código más organizado. El controller se encargaría solo de la entrada del usuario y enviar al sericio y el servicio de la lógica de negocio. 
