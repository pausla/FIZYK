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
using System.Windows.Shapes;

namespace Fizyk
{
    
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        float x,y,z;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            x = 9.86F;
            switch (CBX1.Text)
            {
                case "g":
                    y = float.Parse(TXB1.Text) / 1000;
                    z = x*y;
                    T_Wynik.Text = (z).ToString();
                    T_Wynik.Visibility = Visibility.Visible;
                break;
                case "dag":
                y = float.Parse(TXB1.Text) / 10;
                z = x*y;
                T_Wynik.Text = (z).ToString();
                T_Wynik.Visibility = Visibility.Visible;
                break;
                case "kg":
                y = float.Parse(TXB1.Text);
                z = x*y;
                T_Wynik.Text = (z).ToString();
                T_Wynik.Visibility = Visibility.Visible;
                break;
                case "t":
                y = float.Parse(TXB1.Text)*1000;
                z = x*y;
                T_Wynik.Text = (z).ToString();
                T_Wynik.Visibility = Visibility.Visible;
                break;
            }
        }
    }
}
