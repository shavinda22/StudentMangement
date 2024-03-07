using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentManagementSystem.ViewModels
{
    public partial class UserAddEditWindowVM:ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string userName;
        [ObservableProperty]
        public string password;
        [ObservableProperty]
        public string firstName;
        [ObservableProperty]
        public string lastName;
        [ObservableProperty]
        public string adress;
        [ObservableProperty]
        public string email;
        [ObservableProperty]
        public string phoneNumber;
        [ObservableProperty]
        public bool adminn;

        [RelayCommand]
        public void Save()
        {
            if(userName == null ) {

                MessageBox.Show("Emty fields", "warning");

            }
            CloseWindow();
        }

        private void CloseWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.DialogResult = true;
                    window.Close();
                }
            }
        }
    }
}
