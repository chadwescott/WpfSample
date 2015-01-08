using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CooperVision.Wpf.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var customers = GetCustomers();
            CustomerDataGrid.ItemsSource = customers;
        }

        private static IEnumerable<Customer> GetCustomers()
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

        private void CustomerDataGrid_OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var displayName = GetPropertyDisplayName(e.PropertyDescriptor);

            if (!string.IsNullOrEmpty(displayName))
                e.Column.Header = displayName;
        }

        public static string GetPropertyDisplayName(object descriptor)
        {
            var pd = descriptor as PropertyDescriptor;

            if (pd != null)
            {
                // Check for DisplayName attribute and set the column header accordingly
                var displayName = pd.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;

                if (displayName != null && !(displayName.Equals(DisplayNameAttribute.Default)))
                    return displayName.DisplayName;

            }
            var pi = descriptor as PropertyInfo;

            if (pi == null) return null;
            // Check for DisplayName attribute and set the column header accordingly
            var attributes = pi.GetCustomAttributes(typeof(DisplayNameAttribute), true);
            return (from t in attributes
                select t as DisplayNameAttribute
                into displayName
                        where displayName != null && !(displayName.Equals(DisplayNameAttribute.Default))
                select displayName.DisplayName).FirstOrDefault();
        }

        private void CustomerDataGrid_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            var customer = (Customer)CustomerDataGrid.SelectedItem;
            if (customer == null)
                return;
            var message = String.Format("Please call {0} {1} at {2}", customer.FirstName, customer.LastName,
                customer.PhoneNumber);
            MessageBox.Show(message);
        }
    }
}
