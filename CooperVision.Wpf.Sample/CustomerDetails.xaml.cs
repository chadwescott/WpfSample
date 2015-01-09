using CooperVision.Wpf.Sample.Model;
using CooperVision.Wpf.Sample.ViewModel;

namespace CooperVision.Wpf.Sample
{
    public partial class CustomerDetails
    {
        public CustomerDetails(Customer customer)
        {
            InitializeComponent();
            DataContext = new CustomerDetailsViewModel {SelectedCustomer = customer};
        }
    }
}
