﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment3_F19.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AgricultureDatabaseEntities : DbContext
    {
        public AgricultureDatabaseEntities()
            : base("name=AgricultureDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AgriProduct> AgriProducts { get; set; }
        public virtual DbSet<Fruit> Fruits { get; set; }
        public virtual DbSet<Vegetable> Vegetables { get; set; }
    }
}