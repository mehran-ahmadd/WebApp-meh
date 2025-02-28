using Microsoft.EntityFrameworkCore;

namespace WebApp_meh.Data
{
    public class appDbContext:DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options):base(options)
        {
            
        }





        public DbSet<Persons> Persons { get; set; }
    }

    
}
