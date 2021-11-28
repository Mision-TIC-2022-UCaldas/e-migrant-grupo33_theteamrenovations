using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio
{
    public class Necesidad
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        [Display(Name = "Detalle Necesidad")]
        public String detalles { get; set; }

        public TipoServicio tipoServicio { get; set; }

        public Prioridad prioridad { get; set; }

    }
}