using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ThreeApp
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Contact selectedContact;
        private ObservableCollection<Contact> Contacts { get; set; }
        private RelayCommand addCommand;
        private RelayCommand removeCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        Contact contact = new Contact();
                        Contacts.Insert(0, contact);
                        selectedContact = contact;
                    }));
            }
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        Contact phone = obj as Contact;
                        if (phone != null)
                        {
                            Contacts.Remove(phone);
                        }
                    },
                    (obj) => Contacts.Count > 0));
            }
        }

        public Contact SelectedContact
        {
            get
            {
                return selectedContact;
            }
            set
            {
                selectedContact = value;
                OnPropertyChanged("SelectedContact");
            }
        }

        public ApplicationViewModel()
        {
            Contacts = new ObservableCollection<Contact>
            {
                new Contact {Name = "Володя", Surname = "Путин", Phone= "89369454568"},
                new Contact {Name = "Вера", Surname = "Брежнева", Phone= "89138926538"},
                new Contact {Name = "Игнат", Surname = "Иванов", Phone= "89156505538"},
                new Contact {Name = "Николай", Surname = "Румянцев", Phone= "89115369998"}
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged ([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
