using System;

class Program
{
    static int SumFor(int numero)
    {
        unchecked
        {
            return (numero * (numero + 1)) / 2;
        }
    }

    static int SumIte(int numero)
    {
        unchecked
        {
            int total = 0;
            for (int i = 1; i <= numero; i++)
                total += i;
            return total;
        }
    }

    static int SumIteRapido(int numero) //Optimización para que haga el bucle más rápido
    {
        long exacto = ((long)numero * (numero + 1)) / 2;
        return unchecked((int)exacto);
    }

    static (int n, int suma) BuscarAscFor() // From 1 to Max
    {
        int ultimo = 0, total = 0;
        for (int i = 1; i > 0; i++)
        {
            int s = SumFor(i);
            if (s > 0)
            {
                ultimo = i;
                total = s;
            }
            else break;
        }
        return (ultimo, total);
    }

    static (int n, int suma) BuscarDescFor() //From Max to 1
    {
        for (int i = int.MaxValue; i >= 1; i--)
        {
            int s = SumFor(i);
            if (s > 0) return (i, s);
        }
        return (0, 0);
    }

    static (int n, int suma) BuscarAscIte()
    {
        unchecked
        {
            int total = 0;
            for (int i = 1; i > 0; i++)
            {
                int nuevo = total + i;
                if (nuevo > 0)
                {
                    total = nuevo;
                }
                else
                {
                    return (i - 1, total);
                }
            }
        }
        return (0, 0);
    }

    static (int n, int suma) BuscarDescIte()
    {
        int mejorN = 0;
        int mejorSuma = 0;

        for (int i = int.MaxValue; i >= 1; i--)
        {
            int s = SumIteRapido(i);
            if (s > mejorSuma)
            {
                mejorSuma = s;
                mejorN = i;
            }
            else if (s < mejorSuma)
            {
                break;
            }
        }

        return (mejorN, mejorSuma);
    }

    static void Main() //Resultados 
    {
        var ascFor = BuscarAscFor();
        var descFor = BuscarDescFor();

        var ascIte = BuscarAscIte();
        var descIte = BuscarDescIte();

        Console.WriteLine("• SumFor:");
        Console.WriteLine($"  From 1 to Max → n: {ascFor.n} → sum: {ascFor.suma}");
        Console.WriteLine($"  From Max to 1 → n: {descFor.n} → sum: {descFor.suma}");
        Console.WriteLine();
        Console.WriteLine("• SumIte:");
        Console.WriteLine($"  From 1 to Max → n: {ascIte.n} → sum: {ascIte.suma}");
        Console.WriteLine($"  From Max to 1 → n: {descIte.n} → sum: {descIte.suma}");
    }
}
