using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebApplication1.Models
{
    public class Bitacora
    {
        [Key]
        public string idBitacora { set; get; }
        public string tipo { set; get; }
        public DateTime fecha { set; get; }
        public string nHorasLaboradas { set; get; }
        public string descripcionDetallada { set; get; }
    }
}