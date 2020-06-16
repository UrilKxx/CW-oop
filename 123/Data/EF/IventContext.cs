using System.Data.Entity;

namespace _123
{
    public class IventContext : DbContext
    {
        public IventContext() : base("IventManager")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Ivents> Ivents { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }



    }
}
