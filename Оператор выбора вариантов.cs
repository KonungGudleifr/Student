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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n = int.Parse(Number.Text);
                switch (n)
                {
                    case var _n when _n >= 1 && _n <= 4:Result.Text = "Слабый" ; break ; 
                    case var _n when _n >= 5 && _n <= 10:Result.Text = "Умеренный" ; break ;
                    case var _n when _n >= 9 && _n <= 18:Result.Text = "Сильный" ; break ;
                    default:Result.Text = "Ураганный"; break ; 

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Number.Text = "";
            }
        }
    }
}
