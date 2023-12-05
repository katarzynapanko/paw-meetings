namespace PetsFile.Domain.Pets.ValueObjects
{
    public struct PetId
    {
       public Guid Value { get; init; }          

        public PetId(Guid id)
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
            if (obj is PetId petId)
            {
                return this == petId;
            }
            return false;
        }
        
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        } 
        
        public static implicit operator PetId (Guid id) => new() { Value = id };
        public static bool operator ==(PetId left, PetId right) => left.Value == right.Value;
        public static bool operator !=(PetId left, PetId right) => left.Value != right.Value;
    }
}
