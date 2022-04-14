using DataAccess.Mapping;
using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.ContextConnection
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogComments> BlogComments { get; set;}
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<MyAccounts> MyAccounts { get; set; }
        public DbSet<ReadTables> ReadTables { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2RR55EA\SQLEXPRESS;Database=BartuBlogDatabase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogsCommentsMap());
            modelBuilder.ApplyConfiguration(new BlogsMap());
            modelBuilder.ApplyConfiguration(new MyAccountsMap());
            modelBuilder.ApplyConfiguration(new ReadTablesMap());
        }
         
    }
}
