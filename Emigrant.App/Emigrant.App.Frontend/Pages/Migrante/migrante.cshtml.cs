using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Emigrant.App.Persistencia;
using Emigrant.App.Dominio;
using Microsoft.AspNetCore.Authorization;


namespace Emigrant.App.FrontEnd.Pages
{

    [Authorize]
    public class MigrantesModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());


        public IEnumerable<Migrante> Migrantes { get; set; }

        public void OnGet()
        {
            Migrantes = _repoMigrante.GetAllMigrantes();

        }
    }
}
