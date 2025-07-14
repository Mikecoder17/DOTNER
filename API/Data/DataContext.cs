using API.Entites;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
   public DataContext(DbContextOptions options) : base(options)
   {

   }
   public DbSet<AppUser> Users { get; set; }

   // Define DbSets for your entities here
   // public DbSet<YourEntity> YourEntities { get; set; }
}

