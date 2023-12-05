using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsFile.Domain.Pets.Entities;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFile.Domain.PetsMetadata.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Common.Configurations
{
    public sealed class PetTypeEntityTypeConfiguration : IEntityTypeConfiguration<PetType>
    {
        public void Configure(EntityTypeBuilder<PetType> builder)
        {
            builder.ToTable(nameof(PawsMeetingsDbContext.PetTypes));
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedNever()
                .HasConversion(z => z.Value, z => new PetTypeId(z).Value);
        }
    }
}
 