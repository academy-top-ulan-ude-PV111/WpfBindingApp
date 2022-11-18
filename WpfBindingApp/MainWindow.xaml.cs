using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfBindingApp
{
    class User : INotifyPropertyChanged
    {
        private string name;
        private int age;
        private string? company;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(User.Name));
            }
        }

        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged(nameof(User.Age));
            }
        }

        public string Company
        {
            get => company;
            set
            {
                company = value;
                OnPropertyChanged(nameof(User.Company));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Binding binding = new Binding();
            //binding.ElementName = "text";
            //binding.Path = new PropertyPath("Text");
            //tablo.SetBinding(TextBlock.TextProperty, binding);
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            User u = this.Resources["user"] as User;
            u.Name = "Joe";
        }
    }
}
