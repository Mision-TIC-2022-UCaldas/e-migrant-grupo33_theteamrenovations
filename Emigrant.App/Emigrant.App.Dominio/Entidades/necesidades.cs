using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio
{
    public class necesidades
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        [Display(Name = "Nombres")]
        public int id_servicio { get; set; }

        [Required(ErrorMessage = "Campo apellido obligatorio")]

        public String detalles { get; set; }


    }
}