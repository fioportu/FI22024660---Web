namespace MVC.Models;
using System.ComponentModel.DataAnnotations; // Update: Agregar Anotaciones 

public class TheModel
{
    //Update: Valor requerido y longitud
    //https://chat.deepseek.com/share/toweona8vta01zog3o
    [Required(ErrorMessage = "Please complete the sentence, it is required.")]
    [StringLength(25, MinimumLength = 5, ErrorMessage = "The sentence length should be 5 to 25 characters.")] 
    public string Phrase { get; set; } = string.Empty;

    public Dictionary<char, int> Counts { get; set; } = new();

    public string Lower { get; set; } = string.Empty;

    public string Upper { get; set; } = string.Empty;

}

