using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentManagementSystem.ViewModels
{
    public partial class AddResultWindowVM:ObservableObject
    {
        [ObservableProperty]
        public int studentid;
        [ObservableProperty]
        public string eE3305;
        [ObservableProperty]
        public string eE3302;
        [ObservableProperty]
        public string eE3301;
        [ObservableProperty]
        public string iS3307;
        [ObservableProperty]
        public string eE3250;
        [ObservableProperty]
        public string iS3302;
        [ObservableProperty]
        public string eE3203;
        [ObservableProperty]
        public string eE3251;

        [RelayCommand]
        public void Savee()
        {
            if (Studentid == null)
            {

                MessageBox.Show("Empty fields", "warning");

            }
            CloseWindow();
        }
        [RelayCommand]
        public void CloseWindow()
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
