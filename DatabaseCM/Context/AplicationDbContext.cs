using DatabaseCM.Models.TableDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCM.Context
{
    public class AplicationDbContext: DbContext
    {

        #region constructor

        public AplicationDbContext() : base("name=ComercializadoraDB")
        {

        }
        #endregion

        #region propiedades
        
        public DbSet<estatus> estatus { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Rol> Roles  { get; set; }

        public DbSet<RolPermiso> RolPermisos { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }

        public DbSet<TipoUsuario> tipoUsuarios { get; set; }


        #endregion

    }
}
