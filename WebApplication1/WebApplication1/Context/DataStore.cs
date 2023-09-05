using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class DataStore: DbContext
    {
        public DbSet<Usuario> Usuarios { set; get; }
        public DbSet<Rol> Roles { set; get; }
        public DbSet<InmuebleArea> InmuebleAreas { set; get; }
        public DbSet<Sede> Sedes { set; get; }
        public DbSet<Reunion> Reuniones { set; get; }
        public DbSet<Bitacora> Bitacoras { set; get; }
    }
}