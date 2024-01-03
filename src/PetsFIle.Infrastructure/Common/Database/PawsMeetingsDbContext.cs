using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetsFile.Domain.Matching.Entities;
using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.Entities;
using PetsFile.Domain.PetsMetadata.Entities;
using PetsFIle.Infrastructure.Common.Configurations;

namespace PetsFIle.Infrastructure.Common.Database
{
    public sealed class PawsMeetingsDbContext : IdentityDbContext<IdentityUser>
    {
        public PawsMeetingsDbContext(DbContextOptions<PawsMeetingsDbContext> options) : base(options) { }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<OwnerAddress> OwnerAddress { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<PetTrait> PetTraits { get; set; }
        public DbSet<PetBlackList> PetBlackList { get; set;}
        public DbSet<OwnerBlackList> OwnerBlackLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()
                .HasMany(z => z.PetBlackLists)
                .WithOne(z => z.Pet)
                .HasForeignKey(z => z.PetId)
                .OnDelete(DeleteBehavior.NoAction);

            var traits = DataGenerator.GenerateTraits();
            modelBuilder.Entity<Trait>().HasData(traits);
            var petTypes = DataGenerator.GeneratePetTypes();
            modelBuilder.Entity<PetType>().HasData(petTypes);
            var owners = DataGenerator.GenerateOwner();
            modelBuilder.Entity<Owner>().HasData(owners);
            var ownerIds = owners.Select(z => z.Id).ToArray();
            modelBuilder.Entity<OwnerAddress>().HasData(DataGenerator.GenerateAddresses(ownerIds));
            var petTypeIds = petTypes.Select(z => z.Id).ToArray();
            var pets = DataGenerator.GeneratePet(ownerIds, petTypeIds);
            modelBuilder.Entity<Pet>().HasData(pets);
            var petIds = pets.Select(z => z.Id).ToArray();
            var traitIds = traits.Select(z => z.Id).ToArray();
            modelBuilder.Entity<PetTrait>().HasData(DataGenerator.GeneratePetTrait(petIds, traitIds));
            modelBuilder.Entity<PetBlackList>().HasData(DataGenerator.GeneratePetBlackList(petIds, petTypeIds));
            modelBuilder.Entity<OwnerBlackList>().HasData(DataGenerator.GenerateOwnerBlackList(ownerIds, petTypeIds));
            _ = modelBuilder.ApplyConfiguration(new OwnerEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new PetEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new PetTypeEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new TraitEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new OwnerBlackListEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new PetBlackListEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new OwnerAddressEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new PetTraitEntityTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}