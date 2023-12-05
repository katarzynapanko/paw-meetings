using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsFile.Domain.Matching.Entities;
using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Common.Configurations
{
    public sealed class PetBlackListEntityTypeConfiguration : IEntityTypeConfiguration<PetBlackList>
    {
        public void Configure(EntityTypeBuilder<PetBlackList> builder)
        {
            builder.ToTable(nameof(PawsMeetingsDbContext.PetBlackList));
            builder.HasKey(r => r.Id);
            builder.HasOne(x => x.Pet).WithMany(x => x.PetBlackLists).HasForeignKey(x => x.PetId);
            builder.HasOne(x => x.PetType).WithMany(x => x.PetBlackLists).HasForeignKey(x => x.PetTypeId);
        }
    }
}
