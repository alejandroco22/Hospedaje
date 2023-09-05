using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Rol
    {
        [Key]
        public string idRol { set; get; }
        public string nombreRol { set; get; }
        public string idReunionRol { set; get; }
        public string idSedeRol { set; get; }
        public string idBitacoraRol { set; get; }
    }
}