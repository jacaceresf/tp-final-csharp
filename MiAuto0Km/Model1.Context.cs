﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiAuto0Km
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CerokmEntities : DbContext
    {
        public CerokmEntities()
            : base("name=cerokmdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Concesionaria> Concesionarias { get; set; }
        public virtual DbSet<Contacto> Contactoes { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<TipoAuto> TipoAutoes { get; set; }
        public virtual DbSet<TipoTransmision> TipoTransmisions { get; set; }
        public virtual DbSet<Vehiculo> Vehiculoes { get; set; }
        public virtual DbSet<VehiculoConcesionaria> VehiculoConcesionarias { get; set; }
    }
}
