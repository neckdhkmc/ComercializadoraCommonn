namespace DatabaseCM.Migrations
{
    using DatabaseCM.Constants;
    using DatabaseCM.Models.TableDB;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseCM.Context.AplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseCM.Context.AplicationDbContext context)
        {
            #region catalago de estatus del sistema

            List<estatus> estatus = new List<estatus>()
            {
                EstatusConstans.Activo,
                EstatusConstans.Inactivo
            };
            foreach (var estado in estatus)
            {
                if (!context.estatus.Any(x => x.NombreEstatus == estado.NombreEstatus && x.Descripcion == estado.Descripcion))
                {
                    context.estatus.Add(estado);

                }

            }
            #endregion

            #region catalogo de roles

            List<Rol> Roles = new List<Rol>()
            {
                EstatusConstans.Activo,
                EstatusConstans.Inactivo
            };
            foreach (var estado in estatus)
            {
                if (!context.estatus.Any(x => x.NombreEstatus == estado.NombreEstatus && x.Descripcion == estado.Descripcion))
                {
                    context.estatus.Add(estado);

                }

            }

            #endregion

            #region Catalago de permisos

            #endregion

            #region catalago de tipos de usuarios

            #endregion



        }
    }
}
