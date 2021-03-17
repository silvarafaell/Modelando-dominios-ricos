using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Adress : ValueObject
    {
        public int Street { get; private set; }
        public int Number { get; private set; }
        public int Neigtborhood { get; private set; }
        public int City { get; private set; }
        public int State { get; private set; }
        public int Country { get; private set; }
        public int ZipCode { get; private set; }
    }

}