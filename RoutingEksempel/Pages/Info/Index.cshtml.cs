using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoutingEksempel.Pages.Info
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)] public string message { get; set; } 

        public void OnGet()
        {
        }
    }
}