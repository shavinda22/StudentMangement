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
    public partial class StudentAddEditWindowVM:ObservableObject
    {
        [ObservableProperty]
        public int studid;
        [ObservableProperty]
        public string firstnamE;
        [ObservableProperty]
        public string lastnamE;
        [ObservableProperty]
        public string dOB;
        [ObservableProperty]
        public string addresS;
        [ObservableProperty]
        public string gendeR;
        [ObservableProperty]
        public string phonenumbeR;
        [ObservableProperty]
        public string emaiL;


        [RelayCommand]
        public void Savee()
        {
            if (FirstnamE == null)
            {

                MessageBox.Show("Emty fields", "warning");

            }
            CloseWindow();
        }
        [RelayCommand]
        public void CloseWindow() {
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
