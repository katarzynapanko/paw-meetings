using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsFile.Domain.Matching.Entities;
using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Common.Configurations
{
    public sealed class OwnerBlackListEntityTypeConfiguration : IEntityTypeConfiguration<OwnerBlackList>
    {
        public void Configure(EntityTypeBuilder<OwnerBlackList> builder)
        {
            builder.ToTable(nameof(PawsMeetingsDbContext.OwnerBlackLists));
            builder.HasKey(r => r.Id);
            builder.HasOne(x => x.Owner).WithMany(x => x.OwnerBlackLists).HasForeignKey(x => x.OwnerId);
            builder.HasOne(x => x.PetType).WithMany(x => x.OwnerBlackLists).HasForeignKey(x => x.PetTypeId);
        }
    }
}
