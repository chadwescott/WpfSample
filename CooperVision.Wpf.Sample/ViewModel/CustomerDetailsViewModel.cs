using CooperVision.Wpf.Sample.Model;

namespace CooperVision.Wpf.Sample.ViewModel
{
    public class CustomerDetailsViewModel : BaseViewModel
    {
        private Customer _selectedCustomer;

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
            }
        }
    }
}
