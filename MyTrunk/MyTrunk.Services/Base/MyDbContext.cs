using System.Data.Entity;
using MyTrunk.Model;

namespace MyTrunk.Services.Base
{
    internal class MyDbContext:DbContext
    {
        public MyDbContext()
            : this("name=DefaultConnection")
        {
        }

        public MyDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tUser");
        }
    }
}
