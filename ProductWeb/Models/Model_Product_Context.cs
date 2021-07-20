using System;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductWeb.Models
{
    public class Model_Product_Context : DbContext
    {
        public Model_Product_Context() : base("Product")
        {

        }
        public DbSet<Product> Products { get; set; }

        
    }
}