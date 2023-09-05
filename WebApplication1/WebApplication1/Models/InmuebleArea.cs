using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class InmuebleArea
    {
        [Key]
        public string idInmuebleArea { set; get; }
        public string valorInmueble { set; get; }
        public DateTime diaIngresoInmueble { set; get; }
        public DateTime diaUltimoMantenimiento { set; get; }
        public string tipo { set; get; }
        public string idRolInmuebleArea { set; get; }
    }
}