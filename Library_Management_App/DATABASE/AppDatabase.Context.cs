﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management_App.DATABASE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Library_ManagementEntities : DbContext
    {
        public Library_ManagementEntities()
            : base("name=Library_ManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_Book> tb_Book { get; set; }
        public virtual DbSet<tb_Checkout> tb_Checkout { get; set; }
        public virtual DbSet<tb_Patron> tb_Patron { get; set; }
        public virtual DbSet<tb_UserInfo> UserInfos { get; set; }
    }
}
