using Microsoft.EntityFrameworkCore;

namespace Test.Models {
    
    public class TestDbContext : DbContext {

        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) {
            
        }
        
        public DbSet<Person> People { get; set; }
    }
}