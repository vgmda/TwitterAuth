using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TwitterAuth.Pages;

[Authorize]
public class SecuredPageModel : PageModel
{
    public void OnGet()
    {

    }
}
