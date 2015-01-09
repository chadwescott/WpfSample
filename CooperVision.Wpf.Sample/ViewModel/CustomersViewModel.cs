using System.Collections.Generic;
using CooperVision.Wpf.Sample.Model;

namespace CooperVision.Wpf.Sample.ViewModel
{
    public class CustomersViewModel : BaseViewModel
    {
        private IEnumerable<Customer> _customers;

        public IEnumerable<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                OnPropertyChanged();
            }
        }
    }
}
