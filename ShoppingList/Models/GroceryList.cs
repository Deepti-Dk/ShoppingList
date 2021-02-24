using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShoppingList.Models
{
    public partial class GroceryList : DbContext
    {
        public GroceryList()
            : base("name=GroceryList")
        {
        }

        public virtual DbSet<List> Lists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
