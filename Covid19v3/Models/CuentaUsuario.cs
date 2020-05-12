using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Covid19v3.Models
{
    public class CuentaUsuario
    {

        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "No te olvides del Nombre")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Cantidad de carateres erroneo")]

        public string Nombres { get; set; }
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "No te olvides del Usuario")]


        public string Gmail { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "No te olvides del Clave")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Cantidad de carateres erroneo")]

        public string Password { get; set; }
        public Usuario Usuarios { get; set; }


        public CuentaUsuario(Usuario user, int id)
        {
            Usuarios = user;
            Id = id;
        }

    }
}