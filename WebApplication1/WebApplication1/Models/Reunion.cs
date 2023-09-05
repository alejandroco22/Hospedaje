using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Reunion
    {
        [Key]
        public string idReunion { set; get; }
        public string tipo { set; get; }
        public string meta { set; get; }
        public string descripcionMeta { set; get; }
        public DateTime diaHoraInicio { set; get; }
        public DateTime diaHoraFin { set; get; }
        public string listaEmpleadosParticipantes { set; get; }
        public string descripcionReunion { set; get; }
        public string estadoMeta { set; get; }
        public DateTime diaMaximoCumplimientoMeta { set; get; }
        public string nMeta { set; get; }
    }
}