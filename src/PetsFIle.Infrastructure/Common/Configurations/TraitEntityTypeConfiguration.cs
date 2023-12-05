using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFile.Domain.PetsMetadata.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Common.Configurations
{
    public sealed class TraitEntityTypeConfiguration : IEntityTypeConfiguration<Trait>
    {
        public void Configure(EntityTypeBuilder<Trait> builder)
        {
            builder.ToTable(nameof(PawsMeetingsDbContext.Traits));
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedNever()
                .HasConversion(z => z.Value, z => new TraitId(z).Value);
        }
    }
}
