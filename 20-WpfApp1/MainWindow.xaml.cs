using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace _20_WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<AirDuct> airDucts;

        public MainWindow()
        {
            InitializeComponent();
            airDucts = new ObservableCollection<AirDuct>();
            myDataGrid.ItemsSource = airDucts;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dlina.Text !=String.Empty)
            {
                double diamDuct = Convert.ToDouble(diameter.Text);
                double dlinaDuct = Convert.ToDouble(dlina.Text);
                double areaDouble = Math.Round((diamDuct / 1000) * dlinaDuct * Math.PI, 3);
                area.Text = areaDouble.ToString();

                airDucts.Add(new AirDuct()
                {
                    ID = 1,
                    Name = (string)groupBox1.Header,
                    Size = diameter.Text,
                    Length = dlina.Text,
                    Area = areaDouble
                });
            }
            else
            {
                MessageBox.Show("Требуется ввести длину", "Ошибка при вводе длины", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (dlina1.Text != String.Empty)
            {
                double widthDuct = Convert.ToDouble(width.Text);
                double heightDuct = Convert.ToDouble(height.Text);
                double dlinaDuct = Convert.ToDouble(dlina1.Text);
                double areaDouble = Math.Round((2 * (widthDuct + heightDuct) / 1000) * dlinaDuct, 3);
                area1.Text = areaDouble.ToString();

                airDucts.Add(new AirDuct()
                {
                    ID = 1,
                    Name = (string)groupBox2.Header,
                    Size = width.Text + "x" + height.Text,
                    Length = dlina1.Text,
                    Area = areaDouble
                });
            }
            else
            {
                MessageBox.Show("Требуется ввести длину", "Ошибка при вводе длины", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
