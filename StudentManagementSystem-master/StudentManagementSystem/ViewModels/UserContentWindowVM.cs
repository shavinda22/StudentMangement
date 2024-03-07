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
    public partial class UserContentWindowVM:ObservableObject
    {
        [ObservableProperty]
        public Student selectedstudents;
        [ObservableProperty]
        public List<Student> students;
        [ObservableProperty]
        public int studentId;
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

        public UserContentWindowVM()
        {
            students=new List<Student>();
            GetStudent();

        }
        private void GetStudent()
        {
            using DataContext dataContexts = new DataContext();
            Students = dataContexts.DbStudents.ToList();
        }
        [RelayCommand]
        public void AddStudents()
        {
            var vmm = new StudentAddEditWindowVM();
            var widowaddstudent = new StudentAddEditWindow
            {
                DataContext = vmm
            };
            if (widowaddstudent.ShowDialog() == true)
            {
                var newstudent = new Student
                {
                    FirstNamE = vmm.firstnamE,
                    LastNamE = vmm.lastnamE,
                    DOB = vmm.dOB,
                    Gender = vmm.gendeR,
                    EmaiL = vmm.emaiL,
                    PhoneNumbeR = vmm.phonenumbeR,
                    AdresS = vmm.addresS,
                };
                if (newstudent.FirstNamE != null)
                {
                    using DataContext datacontexts = new DataContext();
                    datacontexts.DbStudents.Add(newstudent);
                    datacontexts.SaveChanges();
                    GetStudent();

                    MessageBox.Show("Student add successfull");

                }
            }
        }

        [RelayCommand]
        public void RemovesStudent()
        {
            using DataContext dataContext = new DataContext();
            if(Selectedstudents != null)
            {
                Student student = dataContext.DbStudents.Single(stu => stu.StudentId == Selectedstudents.StudentId);               
                dataContext.DbStudents.Remove(student);
                dataContext.SaveChanges();
                GetStudent() ;
            }
        }
        [RelayCommand]
        public void UpdatesStudent()
        {

            if (Selectedstudents == null)
            {
                MessageBox.Show("Select student", "Error");
                return;
            }
            else
            {
                using DataContext dataContext = new DataContext();
                var vmm = new StudentAddEditWindowVM
                {
                    FirstnamE = Selectedstudents.FirstNamE,
                    LastnamE = Selectedstudents.LastNamE,
                    EmaiL = Selectedstudents.EmaiL,
                    AddresS = Selectedstudents.AdresS,
                    PhonenumbeR = Selectedstudents.PhoneNumbeR,
                    GendeR = Selectedstudents.Gender,
                    DOB = Selectedstudents.DOB,

                };
                var windoww = new StudentAddEditWindow
                {
                    DataContext = vmm,
                    Title = "Edit"
                };
                if (windoww.ShowDialog() == true)
                {
                    Student student = dataContext.DbStudents.Find(Selectedstudents.StudentId);
                    if (student != null)
                    {
                        student.FirstNamE = vmm.firstnamE;
                        student.LastNamE = vmm.LastnamE;
                        student.EmaiL = vmm.emaiL;
                        student.AdresS = vmm.AddresS;
                        student.PhoneNumbeR = vmm.phonenumbeR;
                        student.Gender = vmm.gendeR;
                        student.DOB = vmm.dOB;
                        dataContext.SaveChanges();
                        MessageBox.Show("Edit Successfully");
                        GetStudent();
                    }
                }



            }
        }
    }

}
