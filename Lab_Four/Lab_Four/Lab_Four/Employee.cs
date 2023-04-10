using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab_Four
{
    public class Employee : INotifyPropertyChanged
    {
        string first_name;
        string last_name;
        string scholastic_degree; //ученая степень

        public string FirstName
        {
            get { return first_name; }
            set
            {
                first_name = value;
                OnPropertyChanged("First name");
                
            }
        }

        public string LastName
        {
            get { return last_name; }
            set
            {
                last_name = value;
                OnPropertyChanged("Last name");
            }
        }

        public string Degree
        {
            get { return scholastic_degree; }
            set
            {
                scholastic_degree = value;
                OnPropertyChanged("Degree");
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
