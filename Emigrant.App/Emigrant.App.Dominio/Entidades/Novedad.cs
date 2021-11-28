using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio
{
    public class Novedad
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo tipo novedad obligatorio")]
        [Display(Name = "Tipo Novedad")]
        public TipoNovedad tipoNovedad { get; set; }
        [Required(ErrorMessage = "Campo ciudad obligatorio")]
        [Display(Name = "Ciudad")]
        public Ciudad ciudad { get; set; }
        [Required(ErrorMessage = "Campo fecha obligatorio")]
        [Display(Name = "Fecha Novedad")]

        public String fechaNovedad { get; set; }
        [Required(ErrorMessage = "Campo numero días obligatorio")]
        [Display(Name = "Número de dias vigencia")]

        public int numeroDias { get; set; }
        [Required(ErrorMessage = "Campo descripción obligatorio")]
        [Display(Name = "Descripción Novedad")]

        public String novedad { get; set; }
        public bool estado { get; set; }

        public int id_entidad { get; set; }

    }
}