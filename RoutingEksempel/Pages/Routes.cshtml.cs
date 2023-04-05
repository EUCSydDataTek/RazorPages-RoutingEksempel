using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace RoutingEksempel.Pages
{
    public class RoutesModel : PageModel
    {

        private readonly IActionDescriptorCollectionProvider _provider;

        public RoutesModel(IActionDescriptorCollectionProvider provider)
        {
            _provider = provider;
        }

        public IReadOnlyList<CompiledPageActionDescriptor> descriptors { get; set; }

        public void OnGet()
        {
            descriptors = _provider.ActionDescriptors.Items.Select(i => i as CompiledPageActionDescriptor).ToList();
        }
    }
}
