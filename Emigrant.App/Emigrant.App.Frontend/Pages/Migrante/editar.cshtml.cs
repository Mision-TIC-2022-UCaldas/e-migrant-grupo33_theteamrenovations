using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Emigrant.App.Persistencia;
using Emigrant.App.Dominio;
namespace Emigrant.App.Frontend.Pages
{
    public class EditarModel : PageModel
    {

        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());
        [BindProperty]

        public Migrante migrante { get; set; }

        public IActionResult OnGet(int? migranteIdentificacion)
        {

            if (migranteIdentificacion.HasValue)
            {
                migrante = _repoMigrante.GetMigrante(migranteIdentificacion.Value);
            }
            else
            {
                migrante = new Migrante();
            }


            if (migrante == null)
            {
                return RedirectToPage("./migrante");
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
                if (migrante.id > 0)
                {

                    _repoMigrante.UpdateMigrante(migrante);
                }
                else
                {
                    Console.WriteLine(migrante);
                    _repoMigrante.AddMigrante(migrante);
                }
            }
            return RedirectToPage("./migrante");
        }
    }
}
