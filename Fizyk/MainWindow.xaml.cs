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

namespace Fizyk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            new OHM().Show();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            new Przyspieszenie().Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Window3().Show();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            new Window4().Show();
        }
    }
}
