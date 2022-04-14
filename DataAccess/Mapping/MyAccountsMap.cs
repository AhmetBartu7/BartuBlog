using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class MyAccountsMap : IEntityTypeConfiguration<MyAccounts>
    {
        public void Configure(EntityTypeBuilder<MyAccounts> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Images).HasMaxLength(50);
            builder.Property(x => x.CoverLetter).HasMaxLength(150);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Github).HasMaxLength(50);
            builder.Property(x => x.Information);
            builder.Property(x => x.Instagram).HasMaxLength(50);
            builder.Property(x => x.Linkedin).HasMaxLength(50);
            builder.Property(x => x.NameSurname).HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(50);
            builder.Property(x => x.Twitter).HasMaxLength(50);

            builder.ToTable("MyAccounts");
        }
    }
}
