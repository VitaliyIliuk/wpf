using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp5
{
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "Anton", Age = 22, Mail = "anton@gmail.com", Phone_number = "6784786423922" });
            items.Add(new User() { Name = "Jodi", Age = 49, Mail = "jodi@gmail.com", Phone_number = "4376341279873" });
            items.Add(new User() { Name = "Sykk", Age = 31, Mail = "Sykk@gmail.com", Phone_number = "798546237893" });
            items.Add(new User() { Name = "Damon", Age = 51, Mail = "damon@gmail.com", Phone_number = "943278975439" });
            items.Add(new User() { Name = "Andrew", Age = 11, Mail = "andrew@gmail.com", Phone_number = "231675567214" });
            items.Add(new User() { Age = 21, Mail = "sasantos231453@gmail.com", Phone_number = "74358467934983" }) ;
            Users.ItemsSource = items;
        }
        public class User : INotifyPropertyChanged
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Mail { get; set; }

            public string Phone_number { get; set; }

            public string PersonName
            {
                get { return Name; }
                set
                {
                    Name = value;
                    OnPropertyChanged();
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged([CallerMemberName] string Name = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }
    }
}
