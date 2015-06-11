using Microsoft.Data.Entity;

namespace VisualStudioCode.WebAPI.Models
{
    public class SalesDbContext : DbContext
    {
		public DbSet<Product> Products { get; set; }
        public DbSet<Code> Codes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Visual Studio 2015 | Use the LocalDb 12 instance created by Visual Studio
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=Sales;Trusted_Connection=True;");

            // Visual Studio 2013 | Use the LocalDb 11 instance created by Visual Studio
            optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=Sales;Trusted_Connection=True;");

            // Visual Studio 2012 | Use the SQL Express instance created by Visual Studio
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Sales;Trusted_Connection=True;");
        }
        
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Code>(b =>
                {
                    b.Property(e => e.Id)
                        .ForSqlServer()
                        .UseIdentity();
                }); 

            modelBuilder.Entity<Product>(b =>
                {
                    b.Property(e => e.Id)
                        .ForSqlServer()
                        .UseIdentity();
                }); 
        }
	}
}