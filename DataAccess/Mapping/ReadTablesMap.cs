using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class ReadTablesMap : IEntityTypeConfiguration<ReadTables>
    {
        public void Configure(EntityTypeBuilder<ReadTables> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.BlogId).IsRequired();
            builder.Property(x => x.ReadDate).HasMaxLength(50);
            builder.Property(x => x.UserIP).IsRequired();
       
            builder.ToTable("ReadTables");
        }
    
    }
}
