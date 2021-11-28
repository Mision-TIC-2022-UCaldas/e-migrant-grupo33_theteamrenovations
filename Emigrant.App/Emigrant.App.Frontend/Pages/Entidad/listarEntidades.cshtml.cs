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

    public class EntidadesModel : PageModel
    {
        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad(new Persistencia.AppContext());


        public IEnumerable<Entidad> Entidades { get; set; }

        public void OnGet()
        {
            Entidades = _repoEntidad.GetAllEntidades();

        }
    }
}
