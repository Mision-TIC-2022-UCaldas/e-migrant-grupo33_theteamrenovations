using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace Emigrant.App.Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrante
    {
        private static AppContext _appContext;
        public RepositorioMigrante(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD 
        //AgregarMigrante
        Migrante IRepositorioMigrante.AddMigrante(Migrante migrante)
        {
            var migranteAdicionado = _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
            return migranteAdicionado.Entity;
        }
        //BuscarMigrante
        Migrante IRepositorioMigrante.GetMigrante(int id)
        {
            var migranteEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.id == id);
            return migranteEncontrado;
        }
        //ActualizarMigrante
        Migrante IRepositorioMigrante.UpdateMigrante(Migrante migrante)
        {
            var migranteEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.id == migrante.id);
            if (migranteEncontrado != null)
            {
                migranteEncontrado.nombre = migrante.nombre;
                migranteEncontrado.apellidos = migrante.apellidos;
                migranteEncontrado.tipo_documento = migrante.tipo_documento;
                migranteEncontrado.identificacion = migrante.identificacion;
                migranteEncontrado.pais = migrante.pais;
                migranteEncontrado.fecha_nacimiento = migrante.fecha_nacimiento;
                migranteEncontrado.correo = migrante.correo;
                migranteEncontrado.telefono = migrante.telefono;
                migranteEncontrado.direccion = migrante.direccion;
                migranteEncontrado.ciudad = migrante.ciudad;
                migranteEncontrado.sit_laboral = migrante.sit_laboral;

                _appContext.SaveChanges();
            }
            return migranteEncontrado;
        }
        //BorrarMigrante

        bool IRepositorioMigrante.DeleteMigrante(int migranteId)
        {
            var migranteEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.id == migranteId);
            if (migranteEncontrado == null)
                return false;
            _appContext.Migrantes.Remove(migranteEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        //BuscarMigrante
        IEnumerable<Migrante> IRepositorioMigrante.GetAllMigrantes()
        {

            return _appContext.Migrantes;

        }



    }
}