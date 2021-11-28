using System.Collections.Generic;
using Emigrant.App.Dominio;

namespace Emigrant.App.Persistencia
{
    public interface IRepositorioNovedad
    {
        //CRUD create - read- update - dlete
        //AddNovedad
        Novedad AddNovedad(Novedad novedad);
        //GetNovedad

        Novedad GetNovedad(int id);

        Novedad UpdateNovedad(Novedad novedad);

        //getAllNovedad
        IEnumerable<Novedad> GetAllNovedades();

    }
}
