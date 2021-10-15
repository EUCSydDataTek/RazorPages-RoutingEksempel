using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingEksempel.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LinkGenerator _linkGenerator;

        public IndexModel(ILogger<IndexModel> logger, LinkGenerator linkGenerator)
        {
            _logger = logger;
            _linkGenerator = linkGenerator;
        }

        public string Link1 { get; set; }

        public string Link2 { get; set; }

        public string Link3 { get; set; }

        public void OnGet()
        {

            Link1 = Url.Page("Privacy");

            Link2 = Url.Page("info/about", new { FirstName = "Jakob", LastName = "Spiel" });

            Link3 = Url.Page("calc/calculate", new { type = "div", a = 100, b = 2 });

        }

        public IActionResult OnPost(int ValueA,int ValueB)
        {
            return RedirectToPage("calc/calculate", new { type = "div",a = ValueA,b = ValueB});
        }
    }

    
}
