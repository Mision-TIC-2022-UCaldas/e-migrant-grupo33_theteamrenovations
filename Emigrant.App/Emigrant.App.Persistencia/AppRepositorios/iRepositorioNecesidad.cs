using System.Collections.Generic;
using Emigrant.App.Dominio;

namespace Emigrant.App.Persistencia
{
    public interface IRepositorioNecesidad
    {
        //CRUD create - read- update - dlete
        //AddNecesidad
        Necesidad AddNecesidad(Necesidad necesidad);
        //GetNecesidad

        Necesidad GetNecesidad(int id);

        Necesidad UpdateNecesidad(Necesidad necesidad);

        //getAllNecesidad
        IEnumerable<Necesidad> GetAllNecesidades();

    }
}
