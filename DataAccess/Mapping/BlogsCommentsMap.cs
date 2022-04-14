using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class BlogsCommentsMap : IEntityTypeConfiguration<BlogComments>
    {
        public void Configure(EntityTypeBuilder<BlogComments> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Commenter).HasMaxLength(50);
            builder.Property(x => x.Comment).HasMaxLength(350);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.BlogId).IsRequired();
            builder.Property(x => x.CommentDate).HasColumnType("datetime");



            builder.ToTable("BlogComments");
        }
    
    }
}
