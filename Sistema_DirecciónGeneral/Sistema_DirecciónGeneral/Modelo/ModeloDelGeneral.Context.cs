﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_DirecciónGeneral.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemaReportesVehiculosEntities : DbContext
    {
        public SistemaReportesVehiculosEntities()
            : base("name=SistemaReportesVehiculosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Conductor> Conductors { get; set; }
        public virtual DbSet<Delegacion> Delegacions { get; set; }
        public virtual DbSet<Dictaman> Dictamen { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Reporte> Reportes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vehiculo> Vehiculoes { get; set; }
        public virtual DbSet<VehiculoReporte> VehiculoReportes { get; set; }
    }
}
