﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hao_CRUD_APP_2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Configuration;
    
    public partial class HAO_Entities : DbContext
    {
        //public HAO_Entities()
        //    : base("name=HAO_Entities")
        //{
        //}

        public HAO_Entities()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var connString = System.Configuration.ConfigurationManager.ConnectionStrings["HAO_Entities"].ToString();
            return connString;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSold> ProductSolds { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}