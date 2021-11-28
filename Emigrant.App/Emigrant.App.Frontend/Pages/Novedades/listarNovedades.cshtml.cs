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
    public class listarNovedadesModel : PageModel
    {
        private static IRepositorioNovedad _repoNovedad = new RepositorioNovedad(new Persistencia.AppContext());


        public IEnumerable<Novedad> Novedades { get; set; }

        public void OnGet()
        {
            Novedades = _repoNovedad.GetAllNovedades();

        }
    }
}
