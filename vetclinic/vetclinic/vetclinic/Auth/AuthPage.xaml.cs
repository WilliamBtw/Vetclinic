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

namespace vetclinic.Auth
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = Helper.EF.Context.Auth.Where(i => i.Login == tbLogin.Text && i.Password == psbPassword.ToString()).FirstOrDefault();
            Helper.EF.user.IdUser = userAuth.IdUser;
            var saveuser = Helper.EF.user;
            switch(saveuser.Rol)
            {
                
            }

            }
            
        }
    }
}
