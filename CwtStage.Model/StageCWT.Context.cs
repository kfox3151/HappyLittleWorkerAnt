﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CwtStage.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StageCWTEntities : DbContext
    {
        public StageCWTEntities()
            : base("name=StageCWTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ODS_CCG> ODS_CCG { get; set; }
        public virtual DbSet<StgODS_CCG> StgODS_CCG { get; set; }
        public virtual DbSet<stgWarehouseSync> stgWarehouseSyncs { get; set; }
        public virtual DbSet<WarehouseSync> WarehouseSyncs { get; set; }
    }
}
