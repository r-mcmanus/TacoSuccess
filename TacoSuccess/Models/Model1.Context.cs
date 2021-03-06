﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TacoSuccess.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class tacosuccessv2Entities : DbContext
    {
        public tacosuccessv2Entities()
            : base("name=tacosuccessv2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<address> addresses { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<custombuild> custombuilds { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<entree> entrees { get; set; }
        public DbSet<ingredient> ingredients { get; set; }
        public DbSet<orderdetail> orderdetails { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<recipe> recipes { get; set; }
        public DbSet<station> stations { get; set; }
        public DbSet<vendor> vendors { get; set; }
    
        public virtual ObjectResult<GetCategory_Result> GetCategory(Nullable<int> catNum)
        {
            var catNumParameter = catNum.HasValue ?
                new ObjectParameter("catNum", catNum) :
                new ObjectParameter("catNum", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCategory_Result>("GetCategory", catNumParameter);
        }
    
        public virtual int GetChosenOrderDetails(Nullable<int> cusID, Nullable<int> ordID)
        {
            var cusIDParameter = cusID.HasValue ?
                new ObjectParameter("CusID", cusID) :
                new ObjectParameter("CusID", typeof(int));
    
            var ordIDParameter = ordID.HasValue ?
                new ObjectParameter("OrdID", ordID) :
                new ObjectParameter("OrdID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetChosenOrderDetails", cusIDParameter, ordIDParameter);
        }
    
        public virtual ObjectResult<GetDetailsForCustomer_Result> GetDetailsForCustomer(Nullable<int> custID)
        {
            var custIDParameter = custID.HasValue ?
                new ObjectParameter("custID", custID) :
                new ObjectParameter("custID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDetailsForCustomer_Result>("GetDetailsForCustomer", custIDParameter);
        }
    
        public virtual ObjectResult<getEntreeByCat_Result> getEntreeByCat(Nullable<int> cat)
        {
            var catParameter = cat.HasValue ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEntreeByCat_Result>("getEntreeByCat", catParameter);
        }
    
        public virtual int GetIngredients(Nullable<int> ingID)
        {
            var ingIDParameter = ingID.HasValue ?
                new ObjectParameter("ingID", ingID) :
                new ObjectParameter("ingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetIngredients", ingIDParameter);
        }
    }
}
