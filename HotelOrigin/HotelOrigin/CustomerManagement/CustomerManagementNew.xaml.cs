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
    /// Interaction logic for CustomerManagementNew.xaml
    /// </summary>
    public partial class CustomerManagementNew : Window
    {
        public CustomerManagementNew()
        {
            InitializeComponent();
        }
        

        private void saveNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            //CustomerManagement parentWindow = (CustomerManagement)Owner;

            Customer newCustomer = new Customer();

            newCustomer.Id = CustomerRepository.Count() + 1;
            newCustomer.EntryDate = DateTime.Now;
            newCustomer.FirstName = firstNameBox.Text;
            newCustomer.LastName = lastNameBox.Text;
            newCustomer.TelephoneNumber = telephoneNumberBox.Text;
            newCustomer.Email = emailBox.Text;
            newCustomer.Notes = notesBox.Text;


            CustomerRepository.Add(newCustomer);
        }
    }
}



