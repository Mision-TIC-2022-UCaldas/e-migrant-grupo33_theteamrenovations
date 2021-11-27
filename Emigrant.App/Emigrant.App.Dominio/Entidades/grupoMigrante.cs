using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio
{
    public class grupoMigrante
    {
        public int id { get; set; }

        [Range(1, 9999999999999, ErrorMessage = "Campo identificacion fuera del rango")]
        public int identificacion { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        public string parentesco { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        public int id_migrante { get; set; }

    }
}