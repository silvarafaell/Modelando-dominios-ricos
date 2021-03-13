using System.Collections.Generic;
using AYMENTCONTEXT.Domain.Entities;

namespace PAYMENTCONTEXT.Domain.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<Subscription> subscriptions { get; set; }
    }
}