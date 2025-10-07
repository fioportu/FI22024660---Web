using Microsoft.AspNetCore.Mvc;
using BinarioCalculator.Models;

namespace BinarioCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BinarioModel());
        }

        [HttpPost]
        public IActionResult Index(BinarioModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Guardar resultados binarios con chars
            model.And = AndStrings(model.A, model.B);
            model.Or  = OrStrings(model.A, model.B);
            model.Xor = XorStrings(model.A, model.B);

            // Operaciones aritméticas con Convert
            int aDec = Convert.ToInt32(model.A, 2);
            int bDec = Convert.ToInt32(model.B, 2);

            int sumRes = aDec + bDec;
            int mulRes = aDec * bDec;

            model.Sum = Convert.ToString(sumRes, 2);
            model.Mul = Convert.ToString(mulRes, 2);

            return View(model);
        }

        // MÉTODOS AUXILIARES PARA OPERACIONES BINARIAS SOBRE STRINGS

        // Alinear dos strings binarios al mismo largo
        private (string, string) Align(string a, string b)
        {
            int len = Math.Max(a.Length, b.Length);
            return (a.PadLeft(len, '0'), b.PadLeft(len, '0'));
        }

        // AND sobre strings
        private string AndStrings(string a, string b)
        {
            (a, b) = Align(a, b);
            char[] result = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
                result[i] = (a[i] == '1' && b[i] == '1') ? '1' : '0';
            return new string(result).TrimStart('0').PadLeft(1, '0');
        }

        // OR sobre strings
        private string OrStrings(string a, string b)
        {
            (a, b) = Align(a, b);
            char[] result = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
                result[i] = (a[i] == '1' || b[i] == '1') ? '1' : '0';
            return new string(result).TrimStart('0').PadLeft(1, '0');
        }

        // XOR sobre strings
        private string XorStrings(string a, string b)
        {
            (a, b) = Align(a, b);
            char[] result = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
                result[i] = (a[i] != b[i]) ? '1' : '0';
            return new string(result).TrimStart('0').PadLeft(1, '0');
        }
    }
}
