using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Windows.Navigation;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Security.Cryptography;
using HotelOrigin.Core;
using HotelOrigin.Core.Repository;


namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Window
    {

        // Selects entry within Data Grid
        private Customer SelectedLogEntry = null;

        //Public = so everyone can see it, the OC class (a smarter list) does something with the logEntry (????) class, naming the new class logEntries
        public ObservableCollection<Customer> customerEntries = new ObservableCollection<Customer>();

        //public DataGridViewEditMode EditMode { get; set; }

        //public = so everyone can see it, static = which is a setting that makes it set, like a reference point?, no idea about the Routed class, Naming it DeletedCommand 
        //and having it be able to receive input
        public static RoutedUICommand DeleteCommand { get; }

        //public = so everyone can see it, MainWindow is the actual main window for the WPF and shows the user the app
        public CustomerManagement()
        {
            //This starts the app up - like a rooster that wakes up an entire farm at dawn
            InitializeComponent();

            //logEntires is now a variable defined as any new instance of the logEntry class ???

            dataGrid.ItemsSource = CustomerRepository.GetAll();
        }

        //Creating a new window for customer information when the add customer button is pressed
        private void customerAddButton_Click(object sender, RoutedEventArgs e)
        {
            //linking to the window that is for new customer information and showing it
            CustomerManagementNew customerWindowNew = new CustomerManagementNew();

            customerWindowNew.Owner = this;

            customerWindowNew.ShowDialog();
        }

        private void customerDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerRepository.Delete(SelectedLogEntry);
        }
        
        // Event of selection (when grid item clicked it is selected)
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // row (selected item) within the data grid (dataGrid) cast within 
            // the customer class (adds functionality)
            SelectedLogEntry = (Customer)dataGrid.SelectedItem;
        }
    }
}
