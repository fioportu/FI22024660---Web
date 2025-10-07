using System.ComponentModel.DataAnnotations;

namespace BinarioCalculator.Models
{
    // Valida que la longitud del string sea múltiplo de 2 (2, 4, 6 u 8)
    public class MultipleOfTwoLengthAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var str = value as string ?? "";
            if (str.Length % 2 != 0)
                return new ValidationResult($"{validationContext.DisplayName} debe tener longitud múltiplo de 2 (2, 4, 6 u 8).");
            return ValidationResult.Success;
        }
    }

    public class BinarioModel
    {
        [Display(Name = "a")]
        [Required(ErrorMessage = "Debe ingresar un valor para a")]
        [RegularExpression("^[01]+$", ErrorMessage = "Solo se permiten 0 y 1")]
        [MaxLength(8, ErrorMessage = "Máximo 8 caracteres")]
        [MultipleOfTwoLength]
        public string A { get; set; } = "";

        [Display(Name = "b")]
        [Required(ErrorMessage = "Debe ingresar un valor para b")]
        [RegularExpression("^[01]+$", ErrorMessage = "Solo se permiten 0 y 1")]
        [MaxLength(8, ErrorMessage = "Máximo 8 caracteres")]
        [MultipleOfTwoLength]
        public string B { get; set; } = "";

        // Resultados
        public string? And { get; set; }
        public string? Or { get; set; }
        public string? Xor { get; set; }
        public string? Sum { get; set; }
        public string? Mul { get; set; }
    }
}
