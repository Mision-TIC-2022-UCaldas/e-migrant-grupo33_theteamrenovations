using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio
{
    public class Entidad
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo NIT es obligatorio")]
        [Display(Name = "NIT")]
        public int nit { get; set; }

        [Required(ErrorMessage = "Campo razon social obligatorio")]
        [Display(Name = "Razon Social")]
        public string razon_Social { get; set; }

        [Required(ErrorMessage = "Campo Direccion obligatorio")]
        [Display(Name = "Direccion")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "Campo ciudad obligatorio")]
        public String ciudad { get; set; }
        [Required(ErrorMessage = "Campo telefono obligatorio")]
        [Display(Name = "Telefono")]
        public String telefonoEntidad { get; set; }
        [Display(Name = "Correo")]
        public String correoEntidad { get; set; }
        public String web { get; set; }
        [Required(ErrorMessage = "Campo Sector  obligatorio")]
        public Sector sector { get; set; }
        [Required(ErrorMessage = "Campo Tipo Servicio obligatorio")]
        [Display(Name = "Tipo Servicio")]
        public TipoServicio tipoServicio { get; set; }
    }
}