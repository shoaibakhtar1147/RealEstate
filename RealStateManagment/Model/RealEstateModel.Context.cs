﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealStateManagment.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RealEstateEntities : DbContext
    {
        public RealEstateEntities()
            : base("name=RealEstateEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Client> Tbl_Client { get; set; }
        public virtual DbSet<Tbl_Colony> Tbl_Colony { get; set; }
        public virtual DbSet<Tbl_Partner> Tbl_Partner { get; set; }
        public virtual DbSet<Tbl_Plot> Tbl_Plot { get; set; }
        public virtual DbSet<Tbl_Partner_Transaction> Tbl_Partner_Transaction { get; set; }
        public virtual DbSet<View_PartnerTransaction> View_PartnerTransaction { get; set; }
        public virtual DbSet<View_Plot> View_Plot { get; set; }
        public virtual DbSet<Tbl_InstallDetail> Tbl_InstallDetail { get; set; }
        public virtual DbSet<Tbl_SaleCash> Tbl_SaleCash { get; set; }
        public virtual DbSet<TBL_SaleInstall> TBL_SaleInstall { get; set; }
        public virtual DbSet<View_SaleCash> View_SaleCash { get; set; }
        public virtual DbSet<View_SaleInstall> View_SaleInstall { get; set; }
    }
}
