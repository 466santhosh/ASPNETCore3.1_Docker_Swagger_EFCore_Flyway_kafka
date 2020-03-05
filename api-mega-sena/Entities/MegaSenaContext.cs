using Microsoft.EntityFrameworkCore;

namespace api_mega_sena.Entities
{
    public class MegaSenaContext : DbContext
    {
        public MegaSenaContext(DbContextOptions<MegaSenaContext> options) : base(options)
        {
            // Creates the database !! Just for DEMO !! in production code you have to handle it differently!  
            this.Database.EnsureCreated();
        }

        /// <summary>  
        /// Gets or sets the products.  
        /// </summary>  
        /// <value>The products.</value>  
        public DbSet<Product> Products { get; set; }
    }
}
