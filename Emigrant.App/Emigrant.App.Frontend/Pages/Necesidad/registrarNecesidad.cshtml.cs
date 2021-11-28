using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Emigrant.App.Persistencia;
using Emigrant.App.Dominio;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Emigrant.App.Frontend.Pages
{
    [Authorize]
    public class RegistroNecesidadModel : PageModel
    {

        private static IRepositorioNecesidad _repoNecesidad = new RepositorioNecesidad(new Persistencia.AppContext());
        [BindProperty]


        public Necesidad necesidad { get; set; }

        public IActionResult OnGet(int? necesidadId)
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (necesidadId.HasValue)
            {
                necesidad = _repoNecesidad.GetNecesidad(necesidadId.Value);
            }
            else
            {
                necesidad = new Necesidad();
            }


            if (necesidad == null)
            {
                return RedirectToPage("../Migrante/migrante");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (necesidad.id > 0)
                {

                    _repoNecesidad.UpdateNecesidad(necesidad);
                }
                else
                {
                    Console.WriteLine(necesidad);
                    _repoNecesidad.AddNecesidad(necesidad);
                }
            }
            return RedirectToPage("./listarEntidades.cshtml");
        }
    }
}
