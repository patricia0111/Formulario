//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Formulario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public partial class datos
    {
        public int Id { get; set; }

        [Required]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }


        [Range(15, 99)]
        public Nullable<int> Edad { get; set; }


        public string Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Correo { get; set; }


        public Genero Genero { get; set; }

        public string Estado_civil { get; set; }

        public string[] Hobbys { get; set; }

    }

    public enum Genero
    {
        Hombre,
        Mujer
    }

}
