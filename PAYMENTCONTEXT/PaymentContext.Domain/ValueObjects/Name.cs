
using System;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (string.IsNullOrEmpty(FirstName))
                AddNotification("Name.FirstName", "Nome inválido");
        }

        private void AddNotification(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

    }
}