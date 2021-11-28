using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace Emigrant.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {
        private static AppContext _appContext;
        public RepositorioNovedad(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD 
        //AgregarNovedad
        Novedad IRepositorioNovedad.AddNovedad(Novedad novedad)
        {
            var novedadAdicionado = _appContext.Novedades.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionado.Entity;
        }
        //BuscarMigrante
        Novedad IRepositorioNovedad.GetNovedad(int id)
        {
            var novedadEncontrado = _appContext.Novedades.FirstOrDefault(p => p.id == id);
            return novedadEncontrado;
        }

        Novedad IRepositorioNovedad.UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrado = _appContext.Novedades.FirstOrDefault(p => p.id == novedad.id);
            if (novedadEncontrado != null)
            {
                novedadEncontrado.tipoNovedad = novedad.tipoNovedad;
                novedadEncontrado.ciudad = novedad.ciudad;
                novedadEncontrado.fechaNovedad = novedad.fechaNovedad;
                novedadEncontrado.numeroDias = novedad.numeroDias;
                novedadEncontrado.novedad = novedad.novedad;
                novedadEncontrado.estado = novedad.estado;
                _appContext.SaveChanges();
            }
            return novedadEncontrado;
        }


        //BuscarNovedad
        IEnumerable<Novedad> IRepositorioNovedad.GetAllNovedades()
        {

            return _appContext.Novedades;

        }

    }
}