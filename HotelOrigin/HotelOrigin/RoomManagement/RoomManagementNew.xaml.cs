using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

namespace HotelOrigin.RoomManagement
{
    /// <summary>
    /// Interaction logic for RoomManagementNew.xaml
    /// </summary>
    public partial class RoomManagementNew : Window
    {
        public RoomManagementNew()
        {
            InitializeComponent();
        }

        private void saveNewRoomButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteNewRoombutton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void yesTvButton_Checked(object sender, RoutedEventArgs e)
        {
            if (yesTvButton.IsChecked == true)
            {
                
            }
       }

        private void noTvButton_Checked(object sender, RoutedEventArgs e)
        {
            if (noTvButton.IsChecked == true)
            {

            }
        }
    }
}
