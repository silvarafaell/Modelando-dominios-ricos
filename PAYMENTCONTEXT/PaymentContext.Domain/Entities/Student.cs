using System.Collections.Generic;
using System.Linq;
using AYMENTCONTEXT.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PAYMENTCONTEXT.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public Adress Address { get; private set; }
        public IReadOnlyCollection<Subscription> subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            //se ja tiver uma assinatura ativa, cancela 

            //cancela todas as assinaturas, e coloca esta como principal
            //como principal
            foreach (var sub in subscriptions)
            {
                sub.Inactivate();
            }

            _subscriptions.Add(subscription);
        }
    }

}