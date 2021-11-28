using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio
{
    public class Necesidad
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Detalle obligatorio")]
        [Display(Name = "Detalle Necesidad")]
        public String detalles { get; set; }

        [Required(ErrorMessage = "Campo Tipo Servicio obligatorio")]
        [Display(Name = "Tipo Servicio")]

        public TipoServicio tipoServicio { get; set; }

        [Required(ErrorMessage = "Campo Prioridad Servicio obligatorio")]
        [Display(Name = "Prioridad")]

        public Prioridad prioridad { get; set; }

        public String Migrante { get; set; }

    }
}