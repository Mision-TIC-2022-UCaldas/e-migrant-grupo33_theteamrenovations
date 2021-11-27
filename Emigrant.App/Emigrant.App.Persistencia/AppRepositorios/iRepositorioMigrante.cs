using System.Collections.Generic;
using Emigrant.App.Dominio;

namespace Emigrant.App.Persistencia
{
    public interface IRepositorioMigrante
    {
        //CRUD create - read- update - dlete
        //AddMigrante
        Migrante AddMigrante(Migrante migrante);
        //GetMigrante

        Migrante GetMigrante(int id);

        //UpdateMigrante

        Migrante UpdateMigrante(Migrante migrante);

        //DeleteMigrante
        bool DeleteMigrante(int id);

        //getAllMigrante
        IEnumerable<Migrante> GetAllMigrantes();

        //GetMigranteEstado

    }
}
