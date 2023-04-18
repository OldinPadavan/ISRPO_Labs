using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Lab_Four
{
    public class Department : INotifyPropertyChanged
    {
        string department_name;
        ObservableCollection<Employee> employees;
        public string DepartmentName
        {
            get { return department_name; }
            set
            {
                department_name = value;
                OnPropertyChanged("Department name");
            }
        }
        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged("Employees");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
