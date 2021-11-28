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
    public class RegistroModel : PageModel
    {

        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad(new Persistencia.AppContext());
        [BindProperty]

        public Entidad entidad { get; set; }

        public IActionResult OnGet(int? entidadId)
        {

            if (entidadId.HasValue)
            {
                entidad = _repoEntidad.GetEntidad(entidadId.Value);
            }
            else
            {
                entidad = new Entidad();
            }


            if (entidad == null)
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
                if (entidad.id > 0)
                {

                    _repoEntidad.UpdateEntidad(entidad);
                }
                else
                {
                    Console.WriteLine(entidad);
                    _repoEntidad.AddEntidad(entidad);
                }
            }
            return RedirectToPage("./listarEntidades.cshtml");
        }
    }
}
