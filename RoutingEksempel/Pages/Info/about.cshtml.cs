using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoutingEksempel.Pages.Info
{
    public class aboutModel : PageModel
    {

        public string Name { get; set; }

        public void OnGet(string FirstName,string LastName)
        {
            Name = $"{FirstName} {LastName}";
        }
    }
}
