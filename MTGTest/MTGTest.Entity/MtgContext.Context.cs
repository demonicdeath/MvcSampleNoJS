﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTGTest.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class MTGEntities : DbContext
    {
        public MTGEntities()
            : base("name=MTGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Site> Sites { get; set; }
        public DbSet<user_Sites> user_Sites { get; set; }
        public DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<SP_BuyingInfluence_Result> SP_BuyingInfluence()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BuyingInfluence_Result>("SP_BuyingInfluence");
        }
    
        public virtual ObjectResult<Nullable<decimal>> Ratio()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Ratio");
        }
    }
}
