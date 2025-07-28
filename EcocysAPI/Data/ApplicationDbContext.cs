using EcocysAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcocysAPI.Data
{
 
      public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options) { }

            public DbSet<ContactUs> ContactUs { get; set; }
        }

}
