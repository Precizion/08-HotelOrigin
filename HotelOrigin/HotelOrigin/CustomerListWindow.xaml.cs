using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HotelOrigin.Core;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for CustomerListWindow.xaml
    /// </summary>
    public partial class CustomerListWindow : Window
    {
        public CustomerListWindow()
        {
            InitializeComponent();
        }

        private void customerButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagement customerWindow = new CustomerManagement();
            customerWindow.Show();

        }

        private void roomButton_Click(object sender, RoutedEventArgs e)
        {
            RoomManagement roomWindow = new RoomManagement();
            roomWindow.Show();

        }

        private void reservationButton_Click(object sender, RoutedEventArgs e)
        {
            ReservationManagement reservationWindow = new ReservationManagement();
            reservationWindow.Show();

        }
    }
}
