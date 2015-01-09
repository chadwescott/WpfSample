using System.Windows.Input;
using CooperVision.Wpf.Sample.Model;
using CooperVision.Wpf.Sample.Repository;
using CooperVision.Wpf.Sample.ViewModel;

namespace CooperVision.Wpf.Sample
{
    public partial class MainWindow
    {
        private readonly CustomersViewModel _model;

        public MainWindow()
        {
            InitializeComponent();

            _model = InitializeCustomerViewModel();
            DataContext = _model;
        }

        private static CustomersViewModel InitializeCustomerViewModel()
        {
            return new CustomersViewModel
            {
                Customers = CustomerRepository.GetCustomers()
            };
        }

        private void CustomerDataGrid_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            var customer = (Customer)CustomerDataGrid.SelectedItem;
            if (customer == null)
                return;
            var detailsWindow = new CustomerDetails(customer);
            detailsWindow.ShowDialog();
        }
    }
}
