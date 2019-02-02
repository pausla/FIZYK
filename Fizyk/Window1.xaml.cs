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
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class OHM : Window
    {
        public OHM()
        {
            InitializeComponent();
        }
        float x,y,z;
        private void BW1_Click(object sender, RoutedEventArgs e)
        {
            switch (CBX3.Text)
            {
                case "mΩ":
                    if (CBX1.Text == "MA")
                    {
                        y = float.Parse(TBX1.Text) * 1000000000;
                    }
                    if (CBX1.Text == "mA")
                    {
                        y = float.Parse(TBX1.Text);
                    }
                    if (CBX1.Text == "A")
                    {
                        y = float.Parse(TBX1.Text) * 1000;
                    }
                    if (CBX1.Text == "kA")
                    {
                        y = float.Parse(TBX1.Text) * 1000000;
                    }
                    if (CBX2.Text == "mV")
                    {
                        x = float.Parse(TBX2.Text);
                    }
                    if (CBX2.Text == "V")
                    {
                        x = float.Parse(TBX2.Text) * 1000;
                    }
                    if (CBX2.Text == "kV")
                    {
                        x = float.Parse(TBX2.Text) * 1000000;
                    }
                    if (CBX2.Text == "MV")
                    {
                        x = float.Parse(TBX2.Text) * 1000000000;
                    }
                    z = x / y;
                    T_Wynik.Text = (z).ToString();
                    T_Wynik.Visibility = Visibility.Visible;
                    break;
                case "Ω":
                    if (CBX1.Text == "MA")
                    {
                        y = float.Parse(TBX1.Text) * 1000000;
                    }
                    if (CBX1.Text == "mA")
                    {
                        y = float.Parse(TBX1.Text) / 1000;
                    }
                    if (CBX1.Text == "A")
                    {
                        y = float.Parse(TBX1.Text);
                    }
                    if (CBX1.Text == "kA")
                    {
                        y = float.Parse(TBX1.Text) * 1000;
                    }
                    if (CBX2.Text == "mV")
                    {
                        x = float.Parse(TBX2.Text) / 1000;
                    }
                    if (CBX2.Text == "V")
                    {
                        x = float.Parse(TBX2.Text);
                    }
                    if (CBX2.Text == "kV")
                    {
                        x = float.Parse(TBX2.Text) * 1000;
                    }
                    if (CBX2.Text == "MV")
                    {
                        x = float.Parse(TBX2.Text) * 1000000;
                    }                    
                    z = x / y;
                    T_Wynik.Text = (z).ToString();
                    T_Wynik.Visibility = Visibility.Visible;
                    break;
                case "kΩ":
                    if (CBX1.Text == "MA")
                    {
                        y = float.Parse(TBX1.Text) * 1000;
                    }
                    if (CBX1.Text == "mA")
                    {
                        y = float.Parse(TBX1.Text) / 1000000;
                    }
                    if (CBX1.Text == "A")
                    {
                        y = float.Parse(TBX1.Text) / 1000;
                    }
                    if (CBX1.Text == "kA")
                    {
                        y = float.Parse(TBX1.Text);
                    }
                    if (CBX2.Text == "mV")
                    {
                        x = float.Parse(TBX2.Text) / 1000000;
                    }
                    if (CBX2.Text == "V")
                    {
                        x = float.Parse(TBX2.Text) / 1000;
                    }
                    if (CBX2.Text == "kV")
                    {
                        x = float.Parse(TBX2.Text);
                    }
                    if (CBX2.Text == "MV")
                    {
                        x = float.Parse(TBX2.Text) * 1000;
                    }
                    z = x / y;
                    T_Wynik.Text = (z).ToString();
                    T_Wynik.Visibility = Visibility.Visible;
                    break;
                case "MΩ":
                    if (CBX1.Text == "MA")
                    {
                        y = float.Parse(TBX1.Text);
                    }
                    if (CBX1.Text == "mA")
                    {
                        y = float.Parse(TBX1.Text) / 1000000000;
                    }
                    if (CBX1.Text == "A")
                    {
                        y = float.Parse(TBX1.Text) / 1000000;
                    }
                    if (CBX1.Text == "kA")
                    {
                        y = float.Parse(TBX1.Text) / 1000;
                    }
                    if (CBX2.Text == "mV")
                    {
                        x = float.Parse(TBX2.Text) / 1000000000;
                    }
                    if (CBX2.Text == "V")
                    {
                        x = float.Parse(TBX2.Text) / 1000000;
                    }
                    if (CBX2.Text == "kV")
                    {
                        x = float.Parse(TBX2.Text) / 1000;
                    }
                    if (CBX2.Text == "MV")
                    {
                        x = float.Parse(TBX2.Text);
                    }
                    z = x / y;
                    T_Wynik.Text = (z).ToString();
                    T_Wynik.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
