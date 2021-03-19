using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Adress : ValueObject
    {
        public Adress(int street, int number, int neigtborhood, int city, int state, int country, int zipCode)
        {
            Street = street;
            Number = number;
            Neigtborhood = neigtborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Street, 3, "Address.Street", "A rua deve conter pelo menos 3 caracteres")
            );
        }

        public int Street { get; private set; }
        public int Number { get; private set; }
        public int Neigtborhood { get; private set; }
        public int City { get; private set; }
        public int State { get; private set; }
        public int Country { get; private set; }
        public int ZipCode { get; private set; }
    }

}