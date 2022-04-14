using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class BlogsMap : IEntityTypeConfiguration<Blogs>
    {
        public void Configure(EntityTypeBuilder<Blogs> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Images).HasMaxLength(50);
            builder.Property(x => x.Explanation);
            builder.Property(x => x.RelaseDate).HasColumnType("datetime");
            builder.Property(x => x.BlogName).HasMaxLength(50);


            builder.HasMany<BlogComments>(x => x.BlogComments).WithOne(x => x.Blogs).HasForeignKey(x => x.BlogId);
            builder.HasMany<ReadTables>(x => x.ReadTables).WithOne(x => x.Blogs).HasForeignKey(x => x.BlogId);
            builder.ToTable("Blogs");



        }
    }
}
