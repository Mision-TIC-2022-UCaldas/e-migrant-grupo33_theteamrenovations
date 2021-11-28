using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace Emigrant.App.Persistencia
{
    public class RepositorioNecesidad : IRepositorioNecesidad
    {
        private static AppContext _appContext;
        public RepositorioNecesidad(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD 
        //AgregarNecesidad
        Necesidad IRepositorioNecesidad.AddNecesidad(Necesidad necesidad)
        {
            var necesidadAdicionado = _appContext.Necesidades.Add(necesidad);
            _appContext.SaveChanges();
            return necesidadAdicionado.Entity;
        }
        //BuscarNecesidad
        Necesidad IRepositorioNecesidad.GetNecesidad(int id)
        {
            var necesidadEncontrado = _appContext.Necesidades.FirstOrDefault(p => p.id == id);
            return necesidadEncontrado;
        }
        //ActualizarNecesidad
        Necesidad IRepositorioNecesidad.UpdateNecesidad(Necesidad necesidad)
        {
            var necesidadEncontrado = _appContext.Necesidades.FirstOrDefault(p => p.id == necesidad.id);
            if (necesidadEncontrado != null)
            {
                necesidadEncontrado.detalles = necesidad.detalles;
                necesidadEncontrado.tipoServicio = necesidad.tipoServicio;
                necesidadEncontrado.prioridad = necesidad.prioridad;

                _appContext.SaveChanges();
            }
            return necesidadEncontrado;
        }

        //BuscarMigrante
        IEnumerable<Necesidad> IRepositorioNecesidad.GetAllNecesidades()
        {

            return _appContext.Necesidades;

        }
    }
}