using System.ComponentModel;

namespace CooperVision.Wpf.Sample
{
    public class Customer
    {
        [DisplayName(@"First Name")]
        public string FirstName { get; set; }

        [DisplayName(@"Last Name")]
        public string LastName { get; set; }

        [DisplayName(@"Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
