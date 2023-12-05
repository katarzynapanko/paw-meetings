using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Common.Configurations
{
    public sealed class OwnerEntityTypeConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.ToTable(nameof(PawsMeetingsDbContext.Owners));
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedNever()
                .HasConversion(z => z.Value, z => new OwnerId(z).Value);
        }
    }
}
