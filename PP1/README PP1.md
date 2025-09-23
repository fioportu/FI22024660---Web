
# PP1 - Practica Programada 1 


**Nombre:** Fiorella Portuguez Rojas  
**Carné:** FI22024660

----------------------------------------------------------------------------

## Estructura del Proyecto

Este proyecto fue desarrollado en Visual Studio 2022, en consola en C#, utilizando .NET 8.0

Se han excluido las carpetas `bin/` y `obj/` como se indica en las instrucciones.

----------------------------------------------------------------------------

## Comandos de dotnet utilizados (CLI)

dotnet new sln -n PP1
dotnet new console -n PP1
dotnet sln add PP1/PP1.csproj
cd PP1
dotnet run


## Fuentes y recursos utilizados

- https://letstalkscience-ca.translate.goog/educational-resources/backgrounders/gauss-summation?_x_tr_sl=en&_x_tr_tl=es&_x_tr_hl=es&_x_tr_pto=tc
- https://learn.microsoft.com/es-es/dotnet/api/system.int32.maxvalue?view=net-9.0
- https://learn.microsoft.com/es-es/dotnet/csharp/
- https://daniccardenas.com/crear-numeros-aleatorios-con-c-sharp/

---

## Prompts y respuestas de IA utilizadas

### ChatGPT (OpenAI)


**Prompt:**  
>  Como puedo implementar un programa en C# para calcular la suma de los primeros números naturales, utilizando gauss

**Respuesta Resumida**

1. Entrada de datos: se pide al usuario un número entero n.
2. Aplicación de la fórmula de Gauss: (n * (n + 1)) / 2.
3. Salida: se muestra el resultado en consola.

Link: https://chatgpt.com/share/68d31dae-f858-8000-9f67-788bea714eb1


**Prompt:**  
>  Como funciona la suma For y la suma Iterativa en C#

**Respuesta Resumida**

1. SumFor: Aquí se usa un bucle for que recorre todos los números desde 1 hasta n y los va acumulando en una variable.
2. SumIte: En este caso no se usa un for, sino un while o un proceso de acumulación descendente (a veces también se refiere a hacerlo de forma manual, sumando con una variable e incrementando un contador).

Link: https://chatgpt.com/share/68d31e36-9810-8000-ab36-28da1b4839a2

**Prompt:**  
>  Como puedo optimizar un SumIte en un programa de C# para que el bucle sea más rápido

**Respuesta Resumida**

1. Usar fórmula matemática: Si lo que quieres es el resultado final, la mejor optimización es reemplazar el bucle por la fórmula de Gauss:
2. Optimizar el bucle: Si tu objetivo es mantener el bucle (por ejemplo, porque es un requisito académico o quieres simular paso a paso), hay varios trucos: Usar loop unrolling o usar tipos adecuados.
3. Paralelizar
 
Link: https://chatgpt.com/share/68d31efc-2d88-8000-a855-618c8c74c97a


### Preguntas y Respuestas ###

1.¿Por qué todos los valores resultantes tanto de n como de sum difieren entre métodos (fórmula e implementación iterativa) y estrategias (ascendente y descendente)?

R/ Porque "SumFor" hace cuentas más grandes en un solo momento, por lo que hace que se equivoqué más rápido, porque los números son más grandes. Además "SumIte" va sumando poco a poco, entonces tarda más tiempo en fallar.


2.¿Qué cree que sucedería si se utilizan las mismas estrategias (ascendente y descendente) pero con el método recursivo de suma (SumRec)? [si desea puede implementarlo y observar qué sucede en ambos escenarios]

R/ Creo que con un método recursivo de suma se llamaría muchas veces a la misma función, puede ser que con números pequeños el programa si corra, pero con números muy grandes posiblemente la computadora se quede sin espacio para realizar muchas consultar y el programa se puede caer. 

