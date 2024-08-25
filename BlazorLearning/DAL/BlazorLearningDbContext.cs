using BlazorLearning.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorLearning.DAL
{
    public class BlazorLearningDbContext:DbContext
    {
        public BlazorLearningDbContext(DbContextOptions<BlazorLearningDbContext> options):base(options)
        {
                
        }
        public DbSet<Master_Inventory_Record> Master_Inventory_Record { get; set; }

    }
}
