using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Usuario
    {
        [Key]
        public string idUsuario { set; get; }
        public string tipoId { set; get; }
        public string nombres { set; get; }
        public string apellidos { set; get; }
        public string paisNacimiento { set; get; }
        public DateTime fechaNacimiento { set; get; }
        public string genero { set; get; }
        public string eMail { set; get; }
        public string telefono { set; get; }
        public string salario { set; get; }
        public string profesion { set; get; }
        public string clave { set; get; }
        public string estadoActual { set; get; }
        public DateTime fechaIngreso { set; get; }
        public DateTime fechaInicioVacaciones { set; get; }
        public DateTime fechaFinVacaciones { set; get; }
        public string idRolUsuario { set; get; }
    }
}