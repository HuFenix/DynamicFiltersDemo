using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EntityFramework.DynamicFilters;

namespace DynamicFiltersDemo
{
    public partial class SSoTestEntities : DbContext
    {
        public SSoTestEntities()
            : base("name=SSoTestEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Filter("ProductsFilter", (Products b) => b.IsDeleted, 0); ;
        }

        public virtual DbSet<Products> Products { get; set; }
       
    }
}

