﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KingBKOT.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KBBQEntities : DbContext
    {
        public KBBQEntities()
            : base("name=KBBQEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ElectronicCurrency> ElectronicCurrencies { get; set; }
        public virtual DbSet<GenEmpID> GenEmpIDs { get; set; }
        public virtual DbSet<genNochargeID> genNochargeIDs { get; set; }
        public virtual DbSet<kotGenerator> kotGenerators { get; set; }
        public virtual DbSet<LogHistory> LogHistories { get; set; }
        public virtual DbSet<tblCurrency> tblCurrencies { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblOrderInfo> tblOrderInfoes { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProType> tblProTypes { get; set; }
        public virtual DbSet<tblTax> tblTaxes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<DailySale> DailySales { get; set; }
        public virtual DbSet<detailsSettlement> detailsSettlements { get; set; }
        public virtual DbSet<purchaseProduct> purchaseProducts { get; set; }
        public virtual DbSet<tblPurchaseOrder> tblPurchaseOrders { get; set; }
        public virtual DbSet<tbl_PurchaseDetails> tbl_PurchaseDetails { get; set; }
        public virtual DbSet<tbl_PurchaseMaster> tbl_PurchaseMaster { get; set; }
        public virtual DbSet<billAndSettlement> billAndSettlements { get; set; }
    }
}
