using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsFile.Domain.PetsMetadata.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Common.Configurations
{
    public sealed class PetTraitEntityTypeConfiguration : IEntityTypeConfiguration<PetTrait>
    {
        public void Configure(EntityTypeBuilder<PetTrait> builder)
        {
            builder.ToTable(nameof(PawsMeetingsDbContext.PetTraits));
            builder.HasKey(r => r.Id);
            builder.HasOne(x => x.Pet).WithMany(x => x.PetTraits).HasForeignKey(x => x.PetId);
            builder.HasOne(x => x.Trait).WithMany(x => x.PetTraits).HasForeignKey(x => x.TraitId);
        }
    }
}
 