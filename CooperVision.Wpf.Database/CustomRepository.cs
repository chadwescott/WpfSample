using System.Collections.Generic;
using System.Linq;

namespace CooperVision.Wpf.Database
{
    public class CustomerRepository
    {
        public static ICollection<Test> GetCustomers()
        {
            using (var context = new NoPrimaryKeyEfTestEntities())
            {
                return context.Tests.ToList();
            }
        }
    }
}
