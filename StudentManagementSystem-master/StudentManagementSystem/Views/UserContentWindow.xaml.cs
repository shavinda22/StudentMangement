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
    /// Interaction logic for UserContentWindow.xaml
    /// </summary>
    public partial class UserContentWindow : Window
    {
        public UserContentWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultsWindow resultsWindow = new ResultsWindow();
            resultsWindow.Show();
            Close();
        }
    }
}
