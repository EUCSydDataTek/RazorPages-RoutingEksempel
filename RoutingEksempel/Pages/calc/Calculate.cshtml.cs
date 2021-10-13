using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoutingEksempel.Pages.calc
{
    public class CalculateModel : PageModel
    {

        [BindProperty(SupportsGet = true)] public string type { get; set; }

        [BindProperty(SupportsGet = true)] public double a { get; set; }

        [BindProperty(SupportsGet = true)] public double b { get; set; }

        public string Calculation { get; set; }
        public double Result { get; set; }

        public void OnGet()
        {

            switch (type)
            {
                case "+":
                    Calculation = $"{a} + {b}";
                    Result = a + b;
                    break;
                case "-":
                    Calculation = $"{a} - {b}";
                    Result = a - b;
                    break;
                case "*":
                    Calculation = $"{a} * {b}";
                    Result = a * b;
                    break;
                case "div":
                    Calculation = $"{a} / {b}";
                    Result = a / b;
                    break;
                case "mod":
                    Calculation = $"{a} % {b}";
                    Result = a % b;
                    break;
                default:
                    break;
            }

        }
    }
}
