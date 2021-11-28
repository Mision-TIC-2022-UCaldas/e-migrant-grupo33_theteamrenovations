using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace Emigrant.App.Persistencia
{
    public class RepositorioEntidad : IRepositorioEntidad
    {
        private static AppContext _appContext;
        public RepositorioEntidad(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD 
        //Agregarentidad
        Entidad IRepositorioEntidad.AddEntidad(Entidad entidad)
        {
            var entidadAdicionado = _appContext.Entidades.Add(entidad);
            _appContext.SaveChanges();
            return entidadAdicionado.Entity;
        }
        //Buscarentidad
        Entidad IRepositorioEntidad.GetEntidad(int id)
        {
            var entidadEncontrado = _appContext.Entidades.FirstOrDefault(p => p.id == id);
            return entidadEncontrado;
        }
        //Actualizarentidad
        Entidad IRepositorioEntidad.UpdateEntidad(Entidad entidad)
        {
            var entidadEncontrado = _appContext.Entidades.FirstOrDefault(p => p.id == entidad.id);
            if (entidadEncontrado != null)
            {
                entidadEncontrado.nit = entidad.nit;
                entidadEncontrado.razon_Social = entidad.razon_Social;
                entidadEncontrado.direccion = entidad.direccion;
                entidadEncontrado.ciudad = entidad.ciudad;
                entidadEncontrado.telefonoEntidad = entidad.telefonoEntidad;
                entidadEncontrado.correoEntidad = entidad.correoEntidad;
                entidadEncontrado.web = entidad.web;
                entidadEncontrado.sector = entidad.sector;
                entidadEncontrado.tipoServicio = entidad.tipoServicio;
                _appContext.SaveChanges();
            }
            return entidadEncontrado;
        }
        //Borrarentidad

        bool IRepositorioEntidad.DeleteEntidad(int entidadId)
        {
            var entidadEncontrado = _appContext.Entidades.FirstOrDefault(p => p.id == entidadId);
            if (entidadEncontrado == null)
                return false;
            _appContext.Entidades.Remove(entidadEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        //Buscarentidad
        IEnumerable<Entidad> IRepositorioEntidad.GetAllEntidades()
        {

            return _appContext.Entidades;

        }
    }
}