using System.Collections.Generic;
using Emigrant.App.Dominio;

namespace Emigrant.App.Persistencia
{
    public interface IRepositorioEntidad
    {
        //CRUD create - read- update - dlete
        //AddEntidad
        Entidad AddEntidad(Entidad entidad);
        //GetEntidad

        Entidad GetEntidad(int id);

        //UpdateEntidad

        Entidad UpdateEntidad(Entidad entidad);

        //DeleteEntidad
        bool DeleteEntidad(int id);

        //getAllEntidad
        IEnumerable<Entidad> GetAllEntidades();

    }
}
