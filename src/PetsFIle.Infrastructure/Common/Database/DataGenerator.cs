using AutoFixture;
using PetsFile.Domain.Matching.Entities;
using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.Entities;
using PetsFile.Domain.Pets.Enums;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFIle.Infrastructure.Common.Database
{

    internal  class DataGenerator 
    {
        private static string[] Names = { "Helen", "Coen", "Paula", "Micah", "Milena", "Beckett", "Amber", "Justice", "Hope",
            "Foster", "Chana", "Clark", "Avayah", "Briar", "Khalani", "Dane", "Leonard", "Demi", "Crosby", "Lu", "Emani" };
        private static string[] Traits = { "active", "lazy", "afraid", "loud", "loving", "loyal", "brave", "shy", "friendly",
            "quiet", "calm", "clumsy", "cheerful", "nervous", "gentle", "smart", "spoiled", "silly", "intelligent", "trustworthy" };
        private static string[] Types = { "Cat", "Dog", "Rat", "Horse", "Snake", "Bird", "Guinea pig", "Rabbit", "Hamster", "Turtle" };
        private static string[] PetNames = {"TAIFA", "BOOZER", "LUPO", "BOOM", "BROWNEY", "MAYA", "RUBY", "FREEDOOM", "TWIGA", "MIKE",
            "FLOKEY", "LUCKIE", "WALTER", "SABASTEIN", "UFEK", "KLUSIA", "MANDO", "BLAZ", "CHUEY", "JUANBOBO", "CASABA", "ALACA", "EDIE"};
        private static string[] Cities = { "Gdansk", "Krakow", "London", "Rome", "Madrid", "Brno", "Prague", "Slupsk", "Warsaw", "Berlin" };
        private static string[] Country = { "Poland", "UK", "Czech Republic", "Italy", "Spain" };
        private static Dictionary<string, string> PostalCode = new Dictionary<string, string>()
        {
            { "Wrzeszcz", "80-251" },
            { "Orunia", "80-59" },
            {"Oliwa", "80-398" },
            {"Starówka", "80-21" },
            {"Brooklyn", "65-154" },
            {"Manhattan", "12-985" },
        };

        const int NumberofOwners = 50;
        
        public static IEnumerable<Trait> GenerateTraits()
        {
            const int numberOfTraits = 20;
            var traits = new List<Trait>(numberOfTraits);
            foreach (var name in Traits)
            {
                var trait = new Trait()
                {
                    DateOfRegistration = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    Name = name
                };
                traits.Add(trait);
            }
            return traits;
        }

        public static IEnumerable<PetTrait> GeneratePetTrait(PetId[] petIds, TraitId[] traitIds) 
        {
            var _petTraits = new List<PetTrait>();
            foreach (var petId in petIds)
            {
                for (int i = 0; i < 3; i++)
                {
                    var petTrait = new PetTrait()
                    {
                        Id = Guid.NewGuid(),
                        PetId = petId,
                        TraitId = traitIds[new Random().Next(traitIds.Length - 1)],
                    };
                    _petTraits.Add(petTrait);
                }
            }
            return _petTraits;
        }

        public static IEnumerable<PetType> GeneratePetTypes()
        {
            const int numberOfTypes = 10;
            var types = new List<PetType>(numberOfTypes);
            for (var i = 0; i < numberOfTypes; i++)
            {
                var typeName = GetPetType();
                var type = new PetType()
                {
                    DateOfRegistration = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    Type = typeName
                };
                types.Add(type);
            }
            return types;
        }

        public static IEnumerable<Pet> GeneratePet(OwnerId[] ownerIds, PetTypeId[] petTypeIds)
        {
            const int numberOfTPets = 100;
            var pets = new List<Pet>(numberOfTPets);
            for (var i = 0; i < numberOfTPets; i++)
            {
                var petName = GetPetName();
                var pet = new Pet()
                {
                    DateOfRegistration = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    DateOfBirth = DateTime.UtcNow.AddYears(new Random().Next(10) * -1),
                    Name = petName,
                    Gender = i == i % 2 ? PetGender.Female : PetGender.Male,
                    PetTypeId = petTypeIds[new Random().Next(petTypeIds.Length - 1)],
                    OwnerId = ownerIds[new Random().Next(ownerIds.Length - 1)]
                };
                pets.Add(pet);
            } 
            return pets;
        }

        public static IEnumerable<OwnerAddress> GenerateAddresses(OwnerId[] ownerIds)
        {
            var fixture = new Fixture();
            const int numberOfAddresses = 50;
            var addresses = new List<OwnerAddress>(numberOfAddresses);
            for (var i = 0; i < numberOfAddresses; i++)
            {
                var country = GetCountry();
                var city = GetCity();
                var district = GetDistrict();
                var address = new OwnerAddress()
                {
                    DateOfRegistration = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    Street = fixture.Create<string>(),
                    District = district.District,
                    City = city,
                    Country = country,
                    PostalCode = district.PostalCode,
                    OwnerId = ownerIds[i]
                };
                addresses.Add(address);
            } 
            return addresses;
        }

        public static IEnumerable<Owner> GenerateOwner()
        {
            var fixture = new Fixture();
            var owners = new List<Owner>(NumberofOwners);
            for (var i = 0; i < NumberofOwners; i++)
            {
                var name = GetName();
                var surname = GetName();
                var owner = new Owner()
                {
                    DateOfRegistration = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    Name = name,
                    Surname = surname,
                    DateOfBirth = fixture.Create<DateTime>(),
                    Email = fixture.Create<string>(),
                    Password = fixture.Create<string>()
                };
                owners.Add(owner);
            }
            return owners;
        }

        public static IEnumerable<PetBlackList> GeneratePetBlackList(PetId[] petIds, PetTypeId[] petTypeIds)
        {
            var numberOfEntries = petIds.Length / 2 + 1;
            var blacklist = new List<PetBlackList>(numberOfEntries);
            var maxPetTypeIdIndex = petTypeIds.Length - 1;
            foreach (var petId in petIds.Take(numberOfEntries))
            {
                var petTypeIdIndex = new Random().Next(maxPetTypeIdIndex);
                for (var i = 0; i < 2; i++)
                {
                    var petBlackList = new PetBlackList()
                    {
                        Id = Guid.NewGuid(),
                        PetId = petId,
                        PetTypeId = petTypeIds[petTypeIdIndex],
                    };
                    blacklist.Add(petBlackList);
                    var newPetTypeIdIndex = new Random().Next(maxPetTypeIdIndex);
                    while (petTypeIdIndex == newPetTypeIdIndex)
                    {
                        newPetTypeIdIndex = new Random().Next(maxPetTypeIdIndex);
                    }
                    petTypeIdIndex = newPetTypeIdIndex;
                }
            }
            return blacklist;
        }

        public static IEnumerable<OwnerBlackList> GenerateOwnerBlackList(OwnerId[] ownerIds, PetTypeId[] petTypeIds)
        {
            var numberOfOwners = (int)Math.Ceiling((double)ownerIds.Length / 2);
            var owners = new List<OwnerBlackList>(numberOfOwners);
            foreach (var ownerId in ownerIds.Take(numberOfOwners))
            {
                var ownerBlackList = new OwnerBlackList()
                {
                    Id = Guid.NewGuid(),
                    OwnerId = ownerId,
                    PetTypeId = petTypeIds[new Random().Next(petTypeIds.Length - 1)],
                };
                owners.Add(ownerBlackList);
            }
            return owners;
        }

        private static string GetPetType()
        {
            return Types[new Random().Next(Types.Length - 1)];
        }

        private static string GetPetName()
        {
            return PetNames[new Random().Next(PetNames.Length - 1)];
        }

        private static string GetName()
        {
            return Names[new Random().Next(Names.Length - 1)];
        }

        private static (string District, string PostalCode) GetDistrict()
        {
            var districtCode = PostalCode.ElementAt(new Random().Next(PostalCode.Count - 1));
            return (districtCode.Key, districtCode.Value);
        }

        private static string GetCity()
        {
            return Cities[new Random().Next(Cities.Length - 1)];
        }

        private static string GetCountry()
        {
            return Country[new Random().Next(Country.Length - 1)];
        }
    }
}