﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<TipoDeVehiculo> TipoDeVehiculos { get; set; }
        public DbSet<Viaje> Viajes { get; set; }
        public DbSet<TipoDeViaje> TipoDeViajes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Chofer> Choferes { get; set; }
        public DbSet<VehiculoViaje> VehiculoViajes { get; set; }
        public DbSet<ViajeChofer> ViajeChoferes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<MarcaDelVehiculo> Marcas { get; set; }
    }
}
