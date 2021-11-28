using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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
        [Display(Name = "Tipo Documento")]
        public int tipo_documento { get; set; }

        [Range(1, 9999999999999, ErrorMessage = "Campo identificacion fuera del rango")]
        [Display(Name = "Identificación")]
        public int identificacion { get; set; }

        [Display(Name = "Pais")]
        public String pais { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        public String fecha_nacimiento { get; set; }
        [Display(Name = "Correo Electrónico")]
        public String correo { get; set; }
        [Display(Name = "Teléfono")]
        public String telefono { get; set; }
        [Display(Name = "Dirección Actual")]
        public String direccion { get; set; }
        [Display(Name = "Ciudad")]
        public Ciudad ciudad { get; set; }
        [Display(Name = "Situacion Laboral")]
        public String sit_laboral { get; set; }

        public List<grupoMigrante> GrupoMigrantes { get; set; }
        public List<Necesidad> necesidades { get; set; }

    }
}