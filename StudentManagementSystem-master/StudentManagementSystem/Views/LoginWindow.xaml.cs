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
using System.Windows.Shapes;

namespace StudentManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var User_Name= UserNameText.Text;
            var Pass_Word= PassWordText.Password;  
            
            using DataContext context = new DataContext();  
            bool adminlog=context.DbUsers.Any(user=>user.UserName == User_Name && user.Password==Pass_Word && user.Adminn==true);
            bool userlog = context.DbUsers.Any(user => user.UserName == User_Name && user.Password == Pass_Word && user.Adminn == false);

            if(adminlog)
            {
                AdmincontentWindow admincontentWindow = new AdmincontentWindow();
                admincontentWindow.Show();
                Close();
            }
            else if(userlog)
            {
                UserContentWindow contentWindow = new UserContentWindow();
                contentWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("invalid username or password","Error" );
            }
        }
    }
}
