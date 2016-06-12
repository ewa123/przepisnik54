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
using System.Windows.Shapes;

namespace przepisnik
{
    /// <summary>
    /// Interaction logic for Dodaj.xaml
    /// </summary>
    public partial class Dodaj : Window
    {
        public ObservableCollection<Class1> Class1List { get; set; }
        public Dodaj()
        {
            InitializeComponent();
            Class1List = new ObservableCollection<Class1>();

            this.PoryDniaComboBox.ItemsSource = Enum.GetValues(typeof(PoryDnia));
           

            

           


            // this.PotrawaComboBox.ItemsSource = Enum.GetValues(typeof(Obiady));
            // this.PotrawaComboBox.SelectedIndex = 0;

        }
        private void cbAllFeatures_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures.IsChecked == true);
            cbFeatureAbc.IsChecked = newVal;
            cbFeatureXyz.IsChecked = newVal;
            cbFeatureWww.IsChecked = newVal;
            cbFeatureAbc1.IsChecked = newVal;
            cbFeatureXyz1.IsChecked = newVal;
            
        }

        private void cbFeature_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures.IsChecked = null;
            if ((cbFeatureAbc.IsChecked == true) && (cbFeatureXyz.IsChecked == true) && (cbFeatureWww.IsChecked == true) && (cbFeatureAbc1.IsChecked == true) && (cbFeatureXyz1.IsChecked == true))
                cbAllFeatures.IsChecked = true;
            if ((cbFeatureAbc.IsChecked == false) && (cbFeatureXyz.IsChecked == false) && (cbFeatureWww.IsChecked == false) && (cbFeatureAbc1.IsChecked == false) && (cbFeatureXyz1.IsChecked == false))
                cbAllFeatures.IsChecked = false;
        }

        private void cbAllFeatures2_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures2.IsChecked == true);
            cbFeatureAbc2.IsChecked = newVal;
            cbFeatureXyz2.IsChecked = newVal;
            cbFeatureWww2.IsChecked = newVal;
            cbFeatureAbc12.IsChecked = newVal;
            cbFeatureXyz12.IsChecked = newVal;
            cbFeatureWww12.IsChecked = newVal;
            cbFeatureAbc112.IsChecked = newVal;
            cbFeatureXyz112.IsChecked = newVal;
            cbFeatureWww112.IsChecked = newVal;
            cbFeatureAbc1112.IsChecked = newVal;
            cbFeatureXyz1112.IsChecked = newVal;
            cbFeatureWww1112.IsChecked = newVal;
        }

        private void cbFeature2_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures2.IsChecked = null;
            if ((cbFeatureAbc2.IsChecked == true) && (cbFeatureXyz2.IsChecked == true) && (cbFeatureWww2.IsChecked == true) && (cbFeatureAbc12.IsChecked == true) && (cbFeatureXyz12.IsChecked == true) && (cbFeatureWww12.IsChecked == true) && (cbFeatureAbc112.IsChecked == true) && (cbFeatureXyz112.IsChecked == true) && (cbFeatureWww112.IsChecked == true) && (cbFeatureAbc1112.IsChecked == true) && (cbFeatureXyz1112.IsChecked == true) && (cbFeatureWww1112.IsChecked == true))
                cbAllFeatures2.IsChecked = true;
            if ((cbFeatureAbc2.IsChecked == false) && (cbFeatureXyz2.IsChecked == false) && (cbFeatureWww2.IsChecked == false) && (cbFeatureAbc12.IsChecked == false) && (cbFeatureXyz12.IsChecked == false) && (cbFeatureWww12.IsChecked == false) && (cbFeatureAbc112.IsChecked == false) && (cbFeatureXyz112.IsChecked == false) && (cbFeatureWww112.IsChecked == false) && (cbFeatureAbc1112.IsChecked == false) && (cbFeatureXyz1112.IsChecked == false) && (cbFeatureWww1112.IsChecked == false))
                cbAllFeatures2.IsChecked = false;
        }

        private void cbAllFeatures3_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures3.IsChecked == true);
            cbFeatureAbc23.IsChecked = newVal;
            cbFeatureXyz23.IsChecked = newVal;
            cbFeatureWww23.IsChecked = newVal;
            cbFeatureAbc123.IsChecked = newVal;
            cbFeatureXyz123.IsChecked = newVal;
            cbFeatureWww123.IsChecked = newVal;
            cbFeatureAbc1123.IsChecked = newVal;
            cbFeatureXyz1123.IsChecked = newVal;
           
        }

        private void cbFeature3_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures3.IsChecked = null;
            if ((cbFeatureAbc23.IsChecked == true) && (cbFeatureXyz23.IsChecked == true) && (cbFeatureWww23.IsChecked == true) && (cbFeatureAbc123.IsChecked == true) && (cbFeatureXyz123.IsChecked == true) && (cbFeatureWww123.IsChecked == true) && (cbFeatureAbc1123.IsChecked == true) && (cbFeatureXyz1123.IsChecked == true) )
                cbAllFeatures3.IsChecked = true;
            if ((cbFeatureAbc23.IsChecked == false) && (cbFeatureXyz23.IsChecked == false) && (cbFeatureWww23.IsChecked == false) && (cbFeatureAbc123.IsChecked == false) && (cbFeatureXyz123.IsChecked == false) && (cbFeatureWww123.IsChecked == false) && (cbFeatureAbc1123.IsChecked == false) && (cbFeatureXyz1123.IsChecked == false) )
                cbAllFeatures3.IsChecked = false;
        }

        private void cbAllFeatures4_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures4.IsChecked == true);
            cbFeatureAbc4.IsChecked = newVal;
            cbFeatureXyz4.IsChecked = newVal;
            cbFeatureWww4.IsChecked = newVal;
            cbFeatureAbc14.IsChecked = newVal;
            cbFeatureXyz14.IsChecked = newVal;

        }

        private void cbFeature4_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures4.IsChecked = null;
            if ((cbFeatureAbc4.IsChecked == true) && (cbFeatureXyz4.IsChecked == true) && (cbFeatureWww4.IsChecked == true) && (cbFeatureAbc14.IsChecked == true) && (cbFeatureXyz14.IsChecked == true))
                cbAllFeatures4.IsChecked = true;
            if ((cbFeatureAbc4.IsChecked == false) && (cbFeatureXyz4.IsChecked == false) && (cbFeatureWww4.IsChecked == false) && (cbFeatureAbc14.IsChecked == false) && (cbFeatureXyz14.IsChecked == false))
                cbAllFeatures4.IsChecked = false;
        }

        private void cbAllFeatures5_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures5.IsChecked == true);
            cbFeatureAbc25.IsChecked = newVal;
            cbFeatureXyz25.IsChecked = newVal;
            cbFeatureWww25.IsChecked = newVal;
            cbFeatureAbc125.IsChecked = newVal;
            cbFeatureXyz125.IsChecked = newVal;
            cbFeatureWww125.IsChecked = newVal;
            cbFeatureAbc1125.IsChecked = newVal;
            cbFeatureXyz1125.IsChecked = newVal;

        }
        private void cbFeature5_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures5.IsChecked = null;
            if ((cbFeatureAbc25.IsChecked == true) && (cbFeatureXyz25.IsChecked == true) && (cbFeatureWww25.IsChecked == true) && (cbFeatureAbc125.IsChecked == true) && (cbFeatureXyz12.IsChecked == true) && (cbFeatureWww125.IsChecked == true) && (cbFeatureAbc1125.IsChecked == true) && (cbFeatureXyz1125.IsChecked == true) )
                cbAllFeatures5.IsChecked = true;
            if ((cbFeatureAbc25.IsChecked == false) && (cbFeatureXyz25.IsChecked == false) && (cbFeatureWww25.IsChecked == false) && (cbFeatureAbc125.IsChecked == false) && (cbFeatureXyz12.IsChecked == false) && (cbFeatureWww125.IsChecked == false) && (cbFeatureAbc1125.IsChecked == false) && (cbFeatureXyz1125.IsChecked == false) )
                cbAllFeatures5.IsChecked = false;
        }

        private void cbAllFeatures6_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures6.IsChecked == true);
            cbFeatureAbc256.IsChecked = newVal;
            cbFeatureXyz256.IsChecked = newVal;
            cbFeatureWww256.IsChecked = newVal;
            cbFeatureAbc1256.IsChecked = newVal;
            cbFeatureXyz1256.IsChecked = newVal;
            cbFeatureWww1256.IsChecked = newVal;


        }

        private void cbFeature6_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures6.IsChecked = null;
            if ((cbFeatureAbc256.IsChecked == true) && (cbFeatureXyz256.IsChecked == true) && (cbFeatureWww256.IsChecked == true) && (cbFeatureAbc1256.IsChecked == true) && (cbFeatureXyz1256.IsChecked == true) && (cbFeatureWww1256.IsChecked == true))
                cbAllFeatures6.IsChecked = true;
            if ((cbFeatureAbc256.IsChecked == false) && (cbFeatureXyz256.IsChecked == false) && (cbFeatureWww256.IsChecked == false) && (cbFeatureAbc1256.IsChecked == false) && (cbFeatureXyz1256.IsChecked == false) && (cbFeatureWww1256.IsChecked == false))
                cbAllFeatures6.IsChecked = false;
        }

        private void cbAllFeatures7_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures7.IsChecked == true);
            cbFeatureAbc7.IsChecked = newVal;
            cbFeatureXyz7.IsChecked = newVal;
            cbFeatureWww7.IsChecked = newVal;
            cbFeatureAbc17.IsChecked = newVal;
            cbFeatureXyz17.IsChecked = newVal;

        }

        private void cbFeature7_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures7.IsChecked = null;
            if ((cbFeatureAbc7.IsChecked == true) && (cbFeatureXyz7.IsChecked == true) && (cbFeatureWww7.IsChecked == true) && (cbFeatureAbc17.IsChecked == true) && (cbFeatureXyz17.IsChecked == true))
                cbAllFeatures7.IsChecked = true;
            if ((cbFeatureAbc7.IsChecked == false) && (cbFeatureXyz7.IsChecked == false) && (cbFeatureWww7.IsChecked == false) && (cbFeatureAbc17.IsChecked == false) && (cbFeatureXyz17.IsChecked == false))
                cbAllFeatures7.IsChecked = false;

        }

        private void cbAllFeatures8_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures8.IsChecked == true);
            cbFeatureAbc258.IsChecked = newVal;
            cbFeatureXyz258.IsChecked = newVal;
            cbFeatureWww258.IsChecked = newVal;
            cbFeatureAbc1258.IsChecked = newVal;
            cbFeatureXyz1258.IsChecked = newVal;
            cbFeatureWww1258.IsChecked = newVal;
            cbFeatureAbc11258.IsChecked = newVal;
            cbFeatureXyz11258.IsChecked = newVal;

        }

        private void cbFeature8_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures8.IsChecked = null;
            if ((cbFeatureAbc258.IsChecked == true) && (cbFeatureXyz258.IsChecked == true) && (cbFeatureWww258.IsChecked == true) && (cbFeatureAbc1258.IsChecked == true) && (cbFeatureXyz1258.IsChecked == true) && (cbFeatureWww1258.IsChecked == true) && (cbFeatureAbc11258.IsChecked == true) && (cbFeatureXyz11258.IsChecked == true))
                cbAllFeatures8.IsChecked = true;
            if ((cbFeatureAbc258.IsChecked == false) && (cbFeatureXyz258.IsChecked == false) && (cbFeatureWww258.IsChecked == false) && (cbFeatureAbc1258.IsChecked == false) && (cbFeatureXyz1258.IsChecked == false) && (cbFeatureWww1258.IsChecked == false) && (cbFeatureAbc11258.IsChecked == false) && (cbFeatureXyz11258.IsChecked == false))
                cbAllFeatures8.IsChecked = false;
        }


        private void DalejButton_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                
                if (PoryDniaComboBox.Text == "Sniadanie")
                {

                    this.PotrawaComboBox.ItemsSource = Enum.GetValues(typeof(Sniadania));
                    this.PotrawaComboBox.SelectedIndex = 0;

                }
                else if (PoryDniaComboBox.Text == "Obiad")
                {

                    this.PotrawaComboBox.ItemsSource = Enum.GetValues(typeof(Obiady));
                    this.PotrawaComboBox.SelectedIndex = 0;

                }
                else if (PoryDniaComboBox.Text == "Kolacja")
                {
                    this.PotrawaComboBox.ItemsSource = Enum.GetValues(typeof(Kolacje));
                    this.PotrawaComboBox.SelectedIndex = 0;

                }
                else if (PoryDniaComboBox.Text == "Przekaski")
                {
                    this.PotrawaComboBox.ItemsSource = Enum.GetValues(typeof(Przekaskii));
                    this.PotrawaComboBox.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("Musisz wybrać porę dnia");
                }
            }
            catch
            {
                MessageBox.Show("Musisz wybrać porę dnia");
            }
        }

        private void WybierzButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Przepis1.Visibility = Visibility.Collapsed;
                this.Przepis2.Visibility = Visibility.Collapsed;
                this.Przepis3.Visibility = Visibility.Collapsed;
                this.Przepis4.Visibility = Visibility.Collapsed;
                this.Przepis5.Visibility = Visibility.Collapsed;
                this.Przepis6.Visibility = Visibility.Collapsed;
                this.Przepis7.Visibility = Visibility.Collapsed;
                this.Przepis8.Visibility = Visibility.Collapsed;

                if (PotrawaComboBox.Text == "PLACUSZKI_Z_JABŁKAMI")
                {

                    this.Przepis1.Visibility = Visibility.Visible;
                    this.Przepis2.Visibility = Visibility.Collapsed;
                    this.Przepis3.Visibility = Visibility.Collapsed;
                    this.Przepis4.Visibility = Visibility.Collapsed;
                    this.Przepis5.Visibility = Visibility.Collapsed;
                    this.Przepis6.Visibility = Visibility.Collapsed;
                    this.Przepis7.Visibility = Visibility.Collapsed;
                    this.Przepis8.Visibility = Visibility.Collapsed;
                }
                if (PotrawaComboBox.Text == "BUŁECZKI_CYNAMONOWE")
                {

                    this.Przepis2.Visibility = Visibility.Visible;
                    this.Przepis1.Visibility = Visibility.Collapsed;
                    this.Przepis3.Visibility = Visibility.Collapsed;
                    this.Przepis4.Visibility = Visibility.Collapsed;
                    this.Przepis5.Visibility = Visibility.Collapsed;
                    this.Przepis6.Visibility = Visibility.Collapsed;
                    this.Przepis7.Visibility = Visibility.Collapsed;
                    this.Przepis8.Visibility = Visibility.Collapsed;
                }

                if (PotrawaComboBox.Text == "FRITTATA_Z_SZYNKĄ")
                {

                    this.Przepis3.Visibility = Visibility.Visible;
                    this.Przepis1.Visibility = Visibility.Collapsed;
                    this.Przepis2.Visibility = Visibility.Collapsed;
                    this.Przepis4.Visibility = Visibility.Collapsed;
                    this.Przepis5.Visibility = Visibility.Collapsed;
                    this.Przepis6.Visibility = Visibility.Collapsed;
                    this.Przepis7.Visibility = Visibility.Collapsed;
                    this.Przepis8.Visibility = Visibility.Collapsed;
                }
                if (PotrawaComboBox.Text == "PLACKI_ZIEMNIACZANE")
                {

                    this.Przepis4.Visibility = Visibility.Visible;
                    this.Przepis1.Visibility = Visibility.Collapsed;
                    this.Przepis2.Visibility = Visibility.Collapsed;
                    this.Przepis3.Visibility = Visibility.Collapsed;
                    this.Przepis5.Visibility = Visibility.Collapsed;
                    this.Przepis6.Visibility = Visibility.Collapsed;
                    this.Przepis7.Visibility = Visibility.Collapsed;
                    this.Przepis8.Visibility = Visibility.Collapsed;
                }

                if (PotrawaComboBox.Text == "MUFFINY_JAJECZNE")
                {

                    this.Przepis5.Visibility = Visibility.Visible;
                    this.Przepis1.Visibility = Visibility.Collapsed;
                    this.Przepis2.Visibility = Visibility.Collapsed;
                    this.Przepis3.Visibility = Visibility.Collapsed;
                    this.Przepis4.Visibility = Visibility.Collapsed;
                    this.Przepis6.Visibility = Visibility.Collapsed;
                    this.Przepis7.Visibility = Visibility.Collapsed;
                    this.Przepis8.Visibility = Visibility.Collapsed;
                }

                if (PotrawaComboBox.Text == "BRUSCHETTA")
                {

                    this.Przepis6.Visibility = Visibility.Visible;
                    this.Przepis1.Visibility = Visibility.Collapsed;
                    this.Przepis2.Visibility = Visibility.Collapsed;
                    this.Przepis3.Visibility = Visibility.Collapsed;
                    this.Przepis4.Visibility = Visibility.Collapsed;
                    this.Przepis5.Visibility = Visibility.Collapsed;
                    this.Przepis7.Visibility = Visibility.Collapsed;
                    this.Przepis8.Visibility = Visibility.Collapsed;
                }

                if (PotrawaComboBox.Text == "OWOCE_ZAPIEKANE_POD_KRUSZONKĄ")
                {

                    this.Przepis7.Visibility = Visibility.Visible;
                    this.Przepis1.Visibility = Visibility.Collapsed;
                    this.Przepis2.Visibility = Visibility.Collapsed;
                    this.Przepis3.Visibility = Visibility.Collapsed;
                    this.Przepis4.Visibility = Visibility.Collapsed;
                    this.Przepis5.Visibility = Visibility.Collapsed;
                    this.Przepis6.Visibility = Visibility.Collapsed;
                    this.Przepis8.Visibility = Visibility.Collapsed;
                }

                if (PotrawaComboBox.Text == "SALSA_POMIDOROWA")
                {

                    this.Przepis8.Visibility = Visibility.Visible;
                    this.Przepis1.Visibility = Visibility.Collapsed;
                    this.Przepis2.Visibility = Visibility.Collapsed;
                    this.Przepis3.Visibility = Visibility.Collapsed;
                    this.Przepis4.Visibility = Visibility.Collapsed;
                    this.Przepis5.Visibility = Visibility.Collapsed;
                    this.Przepis6.Visibility = Visibility.Collapsed;
                    this.Przepis7.Visibility = Visibility.Collapsed; ;
                }
                
            }
            catch
            {
                MessageBox.Show("Dokonaj wyboru przepisu i spróbuj ponownie");
            }


        }

        private void WyjdzButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
