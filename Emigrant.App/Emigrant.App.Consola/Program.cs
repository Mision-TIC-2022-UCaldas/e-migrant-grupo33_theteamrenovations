using System;
using Emigrant.App.Dominio;
using Emigrant.App.Persistencia;
using System.Collections.Generic;

namespace Emigrant.App.Consola
{
    class Program
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            CrearMigrante();

            /*
            //ConsultarMigrante(3);
            //ConsultarMigrantes();            
            //EditarMigrante(4);
            //EliminarMigrante(3);
            /*
            };
            */

        }
        //CRUD
        //CrearMigrante
        private static void CrearMigrante()
        {

            var migrante = new Migrante
            {
                nombre = "Alberto",
                apellidos = "Benitez",
                tipo_documento = 1,
                identificacion = 94229312,
                pais = "Ecuador",
                fecha_nacimiento = DateTime.Now.ToString(),
                correo = "abenitez@hotmail.com",
                telefono = "312",
                direccion = "carrera 8 N 10-19",
                ciudad = "Cucuta",
                sit_laboral = "Desempleado"
            };
            Migrante migranteGuardado = _repoMigrante.AddMigrante(migrante);
            if (migranteGuardado != null)
                Console.WriteLine("Se registró un migrante con éxito");
            else
            {
                Console.WriteLine("Hubo un error de conexión con la base de datos");
            }
        }
        //ConsultarMigrante

        private static Migrante ConsultarMigrante(int idMigrante)
        {
            Migrante migranteEncontrado = _repoMigrante.GetMigrante(idMigrante);
            if (migranteEncontrado != null)
            {
                Console.WriteLine(migranteEncontrado.nombre);
                return migranteEncontrado;
            }
            else
            {
                Console.WriteLine("Migrante no encontrado");
                return null;
            }
        }
        //EditarMigrante
        private static void EditarMigrante(int idMigrante)
        {


            var migrante = new Migrante
            {
                id = idMigrante,
                nombre = "Carlos",
                apellidos = "Gonzalez",
                tipo_documento = 1,
                identificacion = 1105389345,
                pais = "Venezuela",
                fecha_nacimiento = DateTime.Now.ToString(),
                correo = "abenitez@hotmail.com",
                telefono = "312677",
                direccion = "carrera 8 N 10-19",
                ciudad = "Armenia",
                sit_laboral = "Desempleado"
            };
            var migranteActualizado = _repoMigrante.UpdateMigrante(migrante);
            if (migranteActualizado != null)
            {
                Console.WriteLine("Se actualizó el migrante con identificación: " + migranteActualizado.identificacion);
            }
            else
            {
                Console.WriteLine("No se encontró el migrante que se iba a actualizar");
            }

        }
        //EliminarMigrante
        private static void EliminarMigrante(int id)
        {

            if (_repoMigrante.DeleteMigrante(id))
                Console.WriteLine("Migrante Eliminado");
            else
            {
                Console.WriteLine("No se pudo eliminar el migrante con esta identificación,\nverifique que es la identificación correcta.");
            }
        }

        //ConsultarMigrantes

        private static void ConsultarMigrantes()
        {
            IEnumerable<Migrante> Result_migrantes = _repoMigrante.GetAllMigrantes();

            foreach (var iterador in Result_migrantes)
            {
                Console.WriteLine(iterador.nombre + "  " + iterador.apellidos + "  " + iterador.ciudad);

            }

        }



    }
}
