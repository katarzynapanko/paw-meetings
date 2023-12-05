namespace PetsFile.Domain.Pets.ValueObjects
{
    public struct OwnerId
    {
       public Guid Value { get; init; }

        public OwnerId(Guid id)
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
            if (obj is OwnerId ownerId)
            {
                return this == ownerId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static implicit operator OwnerId(Guid id) => new() { Value = id };
        public static bool operator ==(OwnerId left, OwnerId right) => left.Value == right.Value;
        public static bool operator !=(OwnerId left, OwnerId right) => left.Value != right.Value;
    }
}
