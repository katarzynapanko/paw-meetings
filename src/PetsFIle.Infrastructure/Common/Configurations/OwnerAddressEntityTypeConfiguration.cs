using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsFile.Domain.Owners.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Common.Configurations
{
    public sealed class OwnerAddressEntityTypeConfiguration : IEntityTypeConfiguration<OwnerAddress>
    {
        public void Configure(EntityTypeBuilder<OwnerAddress> builder)
        {
            builder.ToTable(nameof(PawsMeetingsDbContext.OwnerAddress));
            builder.HasKey(r => r.Id);
            builder.HasOne(x => x.Owner).WithMany(x => x.OwnerAddresses).HasForeignKey(x => x.OwnerId);
        }
    }
}
