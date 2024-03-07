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
    public partial class AdminContentWindowVM : ObservableObject
    {
        [ObservableProperty]
        public User selecteduser;
        [ObservableProperty]
        public List<User> users;
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string userName;
        [ObservableProperty]
        public string firstName;
        [ObservableProperty]
        public string lastName;
        [ObservableProperty]
        public string email;
        [ObservableProperty]
        public string adminn;

        public AdminContentWindowVM()
        {
            users = new List<User>();
            GetUsers();

            students = new List<Student>();
            GetStudent();
        }

        private void GetUsers()
        {
            using DataContext dataContext = new DataContext();
            Users = dataContext.DbUsers.ToList();
        }

        [RelayCommand]
        public void AddUser()
        {

            var vm = new UserAddEditWindowVM();
            var windowadd = new UserAddEditWindow
            {
                DataContext = vm
            };
            if (windowadd.ShowDialog() == true)
            {
                var newuser = new User
                {
                    UserName = vm.userName,
                    Password = vm.password,
                    FirstName = vm.firstName,
                    LastName = vm.lastName,
                    Email = vm.email,
                    Adress = vm.adress,
                    PhoneNumber = vm.phoneNumber,
                };

                if (newuser.UserName != null)
                {
                    using DataContext dataContext = new DataContext();
                    dataContext.DbUsers.Add(newuser);
                    dataContext.SaveChanges();
                    GetUsers();

                    MessageBox.Show("user add successful", "success", MessageBoxButton.OK);
                }


            }


        }
        [RelayCommand]
        public void RemoveUser()
        {

            using DataContext dataContext = new DataContext();
            if (Selecteduser != null)
            {
                User user = dataContext.DbUsers.Single(usr => usr.Id == Selecteduser.Id);
                dataContext.Remove(user);
                dataContext.SaveChanges();
                GetUsers();
            }
        }
        [RelayCommand]
        public void UpdateUser()
        {
            if (Selecteduser == null)
            {
                MessageBox.Show("Select user", "Error");
                return;
            }
            else
            {
                using DataContext dataContext = new();

                var vm = new UserAddEditWindowVM
                {
                    userName = Selecteduser.UserName,
                    password = Selecteduser.Password,
                    firstName = Selecteduser.FirstName,
                    lastName = Selecteduser.LastName,
                    email = Selecteduser.Email,
                    adress = Selecteduser.Adress,
                    phoneNumber = Selecteduser.PhoneNumber,
                };
                var window = new UserAddEditWindow
                {
                    DataContext = vm,
                    Title = "Edit"
                };
                if (window.ShowDialog() == true)
                {
                    User user = dataContext.DbUsers.Find(Selecteduser.Id);
                    if (user != null)
                    {
                        user.FirstName = vm.firstName;
                        user.LastName = vm.lastName;
                        user.Email = vm.email;
                        user.Adress = vm.adress;
                        user.PhoneNumber = vm.phoneNumber;
                        user.UserName = vm.userName;
                        user.Password = vm.password;
                        dataContext.SaveChanges();
                        MessageBox.Show("Edit Successfully");
                        GetUsers();
                    }
                }
            }
        }


        [ObservableProperty]
        public Student selectedstudent;
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


        private void GetStudent()
        {
            using DataContext dataContexts = new DataContext();
            Students = dataContexts.DbStudents.ToList();
        }
        [RelayCommand]
        public void AddStudent()
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
        public void RemoveStudent()
        {
            using DataContext dataContexts = new DataContext();
            if (Selectedstudent != null)
            {
                Student students = dataContexts.DbStudents.Single(stu => stu.StudentId == Selectedstudent.StudentId);
                dataContexts.DbStudents.Remove(students);
                dataContexts.SaveChanges();
                GetStudent();
            }

        }
        [RelayCommand]
        public void UpdateStudent()
        {
            
            if (Selectedstudent == null)
            {
                MessageBox.Show("Select student", "Error");
                return;
            }
            else
            {
                using DataContext dataContext = new DataContext();
                var vmm = new StudentAddEditWindowVM
                {
                    FirstnamE = Selectedstudent.FirstNamE,
                    LastnamE = Selectedstudent.LastNamE,
                    EmaiL = Selectedstudent.EmaiL,
                    AddresS=Selectedstudent.AdresS,
                    PhonenumbeR=Selectedstudent.PhoneNumbeR,
                    GendeR=Selectedstudent.Gender,
                    DOB=Selectedstudent.DOB,

                };
                var windoww = new StudentAddEditWindow
                {
                    DataContext = vmm,
                    Title = "Edit"
                };
                if (windoww.ShowDialog() == true)
                {
                    Student student = dataContext.DbStudents.Find(Selectedstudent.StudentId);
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

