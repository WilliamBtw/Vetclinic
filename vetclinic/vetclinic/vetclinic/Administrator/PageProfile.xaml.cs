using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vetclinic.Administrator
{
    /// <summary>
    /// Логика взаимодействия для PageProfile.xaml
    /// </summary>
    public partial class PageProfile : Page
    {
        public PageProfile()
        {
            InitializeComponent();
        }

        private void btnAppointment_Click(object sender, RoutedEventArgs e)
        {
            var mainAppointment = new WindowAdmin();
            mainAppointment.frmActivity.Navigate(new PageAdminAppointment());
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProcedure_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMedicalCard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAuthData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
