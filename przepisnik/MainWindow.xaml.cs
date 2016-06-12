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

namespace przepisnik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Class1> Class1List { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Class1List = new ObservableCollection<Class1>();

            this.PoryDniaComboBox.ItemsSource = Enum.GetValues(typeof(PoryDnia));
            this.PoryDniaComboBox.SelectedIndex = 0;
        }

    
        private void WyjdzButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void KontaktButton_Click(object sender, RoutedEventArgs e)
        {
            
              MessageBox.Show("Hello World// Kliknięto przycisk o nazwie ","fdhhgg kjihy");

        }

        

        private void WybierzButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (PoryDniaComboBox.Text == "Sniadanie")
            {
                Window sniadanie = new Sniadanie();
                sniadanie.Show();
            }
          if (PoryDniaComboBox.Text == "Obiad")
            {
                Window obiad = new Obiad();
                obiad.Show();
            }
            if (PoryDniaComboBox.Text == "Kolacja")
            {
                Window kolacja = new Kolacja();
                kolacja.Show();
            }
           if (PoryDniaComboBox.Text=="Przekaski")
            {
                Window przekaski = new Przekaski();
                przekaski.Show();
            }
            /* String wybor = PoryDniaComboBox.Text;
             if (wybor == "Sniadanie")
             {
                 Window sniadanie = new Sniadanie();
                 sniadanie.Show();
             }*/
            /*  else (wybor == "Obiad");
                      {
                  Window obiad = new Obiad();
                  obiad.Show();
              }*/
        }

        private void ListaZakupowButton_Click(object sender, RoutedEventArgs e)
        {
            Window dodaj = new Dodaj();
            dodaj.Show();
        }
    }
}
