using System.Collections.Generic;
using CooperVision.Wpf.Sample.Model;

namespace CooperVision.Wpf.Sample.Repository
{
    public class CustomerRepository
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    FirstName = "John",
                    LastName = "Smith",
                    PhoneNumber = "555-555-5555"
                },
                new Customer
                {
                    FirstName = "Jill",
                    LastName = "Smith",
                    PhoneNumber = "555-555-1111"
                }
            };
        }
    }
}
