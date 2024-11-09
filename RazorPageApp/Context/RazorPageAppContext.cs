using Microsoft.EntityFrameworkCore;
using RazorPageApp.Models;

namespace RazorPageApp.Context
{
    public class RazorPageAppContext:DbContext
    {
        public DbSet<Operator> Operator { get; set; }
        public RazorPageAppContext(DbContextOptions<RazorPageAppContext> opt):base(opt)
        {
            
        }
        public RazorPageAppContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
