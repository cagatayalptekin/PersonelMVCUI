﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonelMVCUI.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersoneldbEntities6 : DbContext
    {
        public PersoneldbEntities6()
            : base("name=PersoneldbEntities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Departman> Departman { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Select> Select { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Sorunlar> Sorunlar { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Sorun> Sorun { get; set; }
    }
}
