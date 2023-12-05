namespace PetsFile.Domain.Pets.ValueObjects
{
    public struct PetTypeId
    {
       public Guid Value { get; init; }

        public PetTypeId(Guid id)
        {
            Value = id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }
            if (obj is Guid id)
            {
                return Value == id;            
            } 
            if (obj is PetTypeId petTypeId)
            {
                return this == petTypeId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static implicit operator PetTypeId(Guid id) => new() { Value = id };
        public static bool operator ==(PetTypeId left, PetTypeId right) => left.Value == right.Value;
        public static bool operator !=(PetTypeId left, PetTypeId right) => left.Value != right.Value;

    }
}
