using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double FirstNumber { get; set; }

        [BindProperty]
        public double SecondNumber { get; set; }

        [BindProperty]
        public string Operation { get; set; } = "add";

        public string Result { get; set; } = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Result = Operation switch
            {
                "add" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "subtract" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "multiply" => $"{FirstNumber} × {SecondNumber} = {FirstNumber * SecondNumber}",
                "divide" => SecondNumber != 0 ? $"{FirstNumber} ÷ {SecondNumber} = {FirstNumber / SecondNumber}" : "Ошибка: деление на ноль",
                _ => "Неизвестная операция"
            };
        }
    }
}