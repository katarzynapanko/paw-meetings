namespace PetsFile.Domain.Pets.ValueObjects
{
    public struct TraitId
    {
       public Guid Value { get; init; }

        public TraitId(Guid id)
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
            if (obj is TraitId traitId)
            {
                return this == traitId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static implicit operator TraitId(Guid id) => new() { Value = id };
        public static bool operator ==(TraitId left, TraitId right) => left.Value == right.Value;
        public static bool operator !=(TraitId left, TraitId right) => left.Value != right.Value;

    }
}
