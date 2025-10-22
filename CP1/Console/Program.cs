public class Numbers
{
    private static readonly double N = 25;

    public static double Formula(double z)
    {
        return Round((z + Math.Sqrt(4 + Math.Pow(z, 2))) / 2);
    }

    public static double Recursive(double z)
    {
        return Round(Recursive(z, N) / Recursive(z, N - 1));
    }

    public static double Iterative(double z)
    {
        return Round(Iterative(z, N) / Iterative(z, N - 1));
    }

    private static double Recursive(double z, double n)
    {
        //Improvement: Coincidir a 10 decimales
        //https://chatgpt.com/share/68f83cff-11f0-8000-877f-d4546be4ab60
        if (n == 0 || n == 1) return 1.0;
        return z * Recursive(z, n - 1) + Recursive(z, n - 2);

    }

    private static double Iterative(double z, double n)
    {
        // Update: Calcular f(z,n) 
        //https://chatgpt.com/share/68f83cff-11f0-8000-877f-d4546be4ab60
        if (n == 0.0 || n == 1.0) return 1.0;

        double f0 = 1.0;
        double f1 = 1.0;
        
        for (int k = 2; k <= (int)n; k++)
        {
            double fk = z * f1 + f0;
            f0 = f1;
            f1 = fk;
        }

        return f1; 
    }

    private static double Round(double value) //Error: Agregar Static
    {
        return Math.Round(value, 10);
    }

    public static void Main(String[] args)
    {
        String[] metallics = [
            "Platinum", // [0]
            "Golden", // [1]
            "Silver", // [2]
            "Bronze", // [3]
            "Copper", // [4]
            "Nickel", // [5]
            "Aluminum", // [6]
            "Iron", // [7]
            "Tin", // [8]
            "Lead", // [9]
        ];
        for (var z = 0; z < metallics.Length; z++)
        {
            Console.WriteLine("\n[" + z + "] " + metallics[z]);
            Console.WriteLine(" ↳ formula(" + z + ")   ≈ " + Formula(z));
            Console.WriteLine(" ↳ recursive(" + z + ") ≈ " + Recursive(z));
            Console.WriteLine(" ↳ iterative(" + z + ") ≈ " + Iterative(z));
        }
    }
}
