using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsFile.Domain.Pets.Entities;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Common.Configurations
{
    public sealed class PetEntityTypeConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable(nameof(PawsMeetingsDbContext.Pets));
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedNever()
                .HasConversion(z => z.Value, z => new PetId(z).Value);
            builder.HasOne(x => x.Owner).WithMany(x => x.Pets).HasForeignKey(x => x.OwnerId);
            builder.HasOne(x => x.PetType).WithMany(x => x.Pets).HasForeignKey(x => x.PetTypeId);
        }
    }
}
