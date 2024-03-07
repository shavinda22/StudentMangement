using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentManagementSystem.Models;
using StudentManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentManagementSystem.ViewModels
{
    public partial class ResultWindowVM:ObservableObject
    {
        [ObservableProperty]
        public Result selectedresult;
        [ObservableProperty]
        public List<Result> results;
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

        public ResultWindowVM()
        {
            results = new List<Result>();
            GetResult();

        }
        private void GetResult()
        {
            using DataContext dataContext = new DataContext();
            Results = dataContext.DbResult.ToList();
        }

        [RelayCommand]
        public void AddResult()
        {
            var vm = new AddResultWindowVM();
            var windowadd = new AddResultWindow
            {
                DataContext = vm
            };
            if (windowadd.ShowDialog() == true)
            {
                var newresult = new Result
                {
                    EE3305 = vm.eE3305,
                   EE3302= vm.eE3302,
                    EE3301 = vm.EE3301,
                    IS3307 = vm.IS3307,
                    EE3250 = vm.EE3250,
                    IS3302 = vm.IS3302,
                    EE3203 = vm.eE3203,
                    EE3251 = vm.EE3251,
                };

                if (newresult.EE3305 != null)
                {
                    using DataContext dataContext = new DataContext();
                    dataContext.DbResult.Add(newresult);
                    dataContext.SaveChanges();
                    GetResult();    

                    MessageBox.Show("Result add successful", "success", MessageBoxButton.OK);
                }


            }

        }
    }
}
