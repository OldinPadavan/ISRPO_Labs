using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab_Four
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Department> departments { get; set; }
        public MainWindow ( )
        {
            InitializeComponent();
            departments = new ObservableCollection<Department>()
            {
                new Department()
                {
                    DepartmentName = "Advanced bionic technology",
                    Employees = new ObservableCollection<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "Isaac",
                            LastName = "Asimov",
                            Degree = "M.Sc"

                        },

                        new Employee()
                        {
                            FirstName = "Ray",
                            LastName = "Bradbury",
                            Degree = "-"

                        },

                        new Employee()
                        {
                            FirstName = "Philip",
                            LastName = "Dick",
                            Degree = "-"

                        }
                    }
                },

                 new Department()
                {
                    DepartmentName = "Alien life forms",
                    Employees = new ObservableCollection<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "",
                            LastName = "",
                            Degree = ""

                        },

                        new Employee()
                        {
                            FirstName = "",
                            LastName = "",
                            Degree = ""

                        },

                        new Employee()
                        {
                            FirstName = "",
                            LastName = "",
                            Degree = ""

                        }
                    }
                },
                 new Department()
                {
                    DepartmentName = "Experimental physics and theory of teleportation",
                    Employees = new ObservableCollection<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "",
                            LastName = "",
                            Degree = ""

                        },

                        new Employee()
                        {
                            FirstName = "",
                            LastName = "",
                            Degree = ""

                        },

                        new Employee()
                        {
                            FirstName = "",
                            LastName = "",
                            Degree = ""

                        }
                    }
                }
            };
            
        }
    }
}
