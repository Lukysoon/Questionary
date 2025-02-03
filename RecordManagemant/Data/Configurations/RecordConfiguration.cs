using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordManagemant.Entities;

namespace RecordManagemant.Data.Configurations
{
    public class RecordConfiguration : IEntityTypeConfiguration<Record>
    {
        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder.Property(r => r.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(r => r.LastName).IsRequired().HasMaxLength(100);
            builder.Property(r => r.PersonalIdentificationNumber).HasMaxLength(50);
            builder.Property(r => r.DateOfBirth).IsRequired();
            builder.Property(r => r.Gender).IsRequired();
            builder.Property(r => r.Email).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Nationality).IsRequired().HasMaxLength(100);
            builder.Property(r => r.GdprConsent).IsRequired();
        }
    }
}
