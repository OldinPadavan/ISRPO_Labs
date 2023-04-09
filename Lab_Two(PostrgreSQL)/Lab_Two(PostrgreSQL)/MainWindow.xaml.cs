using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

namespace Lab_Two_PostrgreSQL_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonsContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new PersonsContext();
            db.Persons.Load();
            dgPeople.ItemsSource = db.Persons.Local.ToBindingList();

            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs args)
        {
            db.Dispose();
        }

        private void bUpdate_Click(object sender, RoutedEventArgs args)
        {
            db.SaveChanges();
        }

        private void bDelete_Click(object sender, RoutedEventArgs args)
        {
            if (dgPeople.SelectedItems.Count > 0)
            {
                for (int i = 0; i < dgPeople.SelectedItems.Count; i++)
                {
                    Person phone = dgPeople.SelectedItems[i] as Person;
                    if (phone != null)
                    {
                        db.Persons.Remove(phone);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
