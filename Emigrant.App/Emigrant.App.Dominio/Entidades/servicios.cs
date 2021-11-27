using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio
{
    public class servicios
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        [Display(Name = "Nombres")]
        public string nombreServicio { get; set; }

        [Required(ErrorMessage = "Campo apellido obligatorio")]
        [Display(Name = "Numero de Cupos")]
        public int numCupos { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        public DateTime fechaIni { get; set; }

        [Required(ErrorMessage = "Campo nombre obligatorio")]
        public DateTime fechaFinal { get; set; }

        public Prioridad prioridad { get; set; }

    }
}