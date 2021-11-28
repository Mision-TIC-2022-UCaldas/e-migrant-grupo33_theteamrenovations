using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio
{
    public class Migrante
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        [Display(Name = "Nombres")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Campo apellido obligatorio")]
        [Display(Name = "Apellidos")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        public int tipo_documento { get; set; }

        [Range(1, 9999999999999, ErrorMessage = "Campo identificacion fuera del rango")]
        public int identificacion { get; set; }

        public String pais { get; set; }

        public String fecha_nacimiento { get; set; }

        public String correo { get; set; }

        public String telefono { get; set; }

        public String direccion { get; set; }

        public Ciudad ciudad { get; set; }

        public String sit_laboral { get; set; }
    }
}