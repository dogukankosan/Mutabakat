﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETARaporlama.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ETA_TEK2012_2012Entities : DbContext
    {
        public ETA_TEK2012_2012Entities()
            : base("name=ETA_TEK2012_2012Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CARKART> CARKART { get; set; }
        public virtual DbSet<ADRESLER> ADRESLER { get; set; }
    }
}
