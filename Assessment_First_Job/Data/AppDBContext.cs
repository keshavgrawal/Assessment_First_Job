using Assessment_First_Job.Model;
using Microsoft.EntityFrameworkCore;

namespace Assessment_First_Job.Data
{
    public class AppDBContext(DbContextOptions<AppDBContext>options) : DbContext(options)
    {
        public DbSet<UserDetails> UserDetails {  get; set; }
    }
}
