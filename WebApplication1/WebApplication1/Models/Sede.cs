using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sede
    {
        [Key]
        public string idSede { set; get; }
        public string direccion { set; get; }
        public string localidad { set; get; }
        public string ciudad { set; get; }
        public string estrato { set; get; }
        public string web { set; get; }
        public string telefono { set; get; }
        public string nMaximoHuespedes { set; get; }
        public string nMaximoEmpleados { set; get; }
        public string nAreasFisicas { set; get; }
        public string nHabitaciones { set; get; }
        public DateTime diaARenovarRNT { set; get; }
        public DateTime diaInauguracion { set; get; }
        public string recibosProveedores { set; get; }
    }
}