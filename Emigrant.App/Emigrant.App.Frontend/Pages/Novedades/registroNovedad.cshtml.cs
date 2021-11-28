using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Emigrant.App.Persistencia;
using Emigrant.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace Emigrant.App.Frontend.Pages
{
    [Authorize]
    public class RegistroNovedadModel : PageModel
    {

        private static IRepositorioNovedad _repoNovedad = new RepositorioNovedad(new Persistencia.AppContext());
        [BindProperty]

        public Novedad novedad { get; set; }

        public IActionResult OnGet(int? novedadId)
        {

            if (novedadId.HasValue)
            {
                novedad = _repoNovedad.GetNovedad(novedadId.Value);
            }
            else
            {
                novedad = new Novedad();
            }


            if (novedad == null)
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
                if (novedad.id > 0)
                {

                    _repoNovedad.UpdateNovedad(novedad);
                }
                else
                {
                    Console.WriteLine(novedad);
                    _repoNovedad.AddNovedad(novedad);
                }
            }
            return RedirectToPage("./listarEntidades.cshtml");
        }
    }
}
