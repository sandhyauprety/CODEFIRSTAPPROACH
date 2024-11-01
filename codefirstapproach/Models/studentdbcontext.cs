using Microsoft.EntityFrameworkCore;

namespace codefirstapproach.Models
{
    public class studentdbcontext:DbContext
    {
        public studentdbcontext (DbContextOptions options):base(options) 
        {

        }

        public DbSet<student>students { get; set; }

    }
}
