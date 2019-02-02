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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        float x, y, z;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (CBX1_W3.Text)
            {   case "km/h" :
                    if (CBX_droga.Text == "m")
                    {
                        y = float.Parse(TXB1_W3.Text)/1000;                       
                    }
                    if(CBX_czas.Text == "s")
                    {
                        z = float.Parse(TXB2_W3.Text) / 3600;
                    }
                    if (CBX_droga.Text == "cm" )
                    {
                        y = float.Parse(TXB1_W3.Text)/100000;                      
                    }
                    if(CBX_czas.Text == "min")
                    {
                        z = float.Parse(TXB2_W3.Text) / 60;
                    }
                    if (CBX_droga.Text=="mm")
                    {
                        y = float.Parse(TXB1_W3.Text)/1000000;                      
                    }
                    if(CBX_czas.Text == "ms")
                    {
                        z = float.Parse(TXB2_W3.Text) / 3600000; 
                    }
                    if(CBX_droga.Text=="km")
                    {
                        y = float.Parse(TXB1_W3.Text);
                    }
                    if (CBX_czas.Text == "h")
                    {
                        z = float.Parse(TXB2_W3.Text);
                    }
                        x = y / z;
                        Wynik_W3.Text = (x).ToString();
                        Wynik_W3.Visibility = Visibility.Visible;
                        break;
                case "m/s":
                    if (CBX_droga.Text == "m")
                    {
                        y = float.Parse(TXB1_W3.Text);
                    }
                    if (CBX_czas.Text == "s")
                    {
                         z = float.Parse(TXB2_W3.Text);
                    }
                    if (CBX_droga.Text == "cm")
                    {
                        y = float.Parse(TXB1_W3.Text)/100;
                    }
                    if (CBX_czas.Text == "min")
                    {
                        z = float.Parse(TXB2_W3.Text)*60;
                    }
                    if (CBX_droga.Text == "mm")
                    {
                        y = float.Parse(TXB1_W3.Text) / 1000;
                    }
                    if (CBX_czas.Text == "ms")
                    {
                        z = float.Parse(TXB2_W3.Text) / 1000;
                    }
                    if (CBX_droga.Text == "km")
                    {
                        y = float.Parse(TXB1_W3.Text) * 1000;
                    }
                    if (CBX_czas.Text == "h")
                    {
                        z = float.Parse(TXB2_W3.Text)*3600;
                    }
                        x = y / z;
                        Wynik_W3.Text = (x).ToString();
                        Wynik_W3.Visibility = Visibility.Visible;
                        break;
                case "cm/min":
                        if (CBX_droga.Text == "m")
                        {
                            y = float.Parse(TXB1_W3.Text)*100;
                        }
                        if (CBX_czas.Text == "s")
                        {
                            z = float.Parse(TXB2_W3.Text)/60;
                        }
                        if (CBX_droga.Text == "cm")
                        {
                            y = float.Parse(TXB1_W3.Text);
                        }
                        if (CBX_czas.Text == "min")
                        {
                            z = float.Parse(TXB2_W3.Text);
                        }
                        if (CBX_droga.Text == "mm")
                        {
                            y = float.Parse(TXB1_W3.Text)/ 10;
                        }
                        if (CBX_czas.Text == "ms")
                        {
                            z = float.Parse(TXB2_W3.Text) / 60000;
                        }
                        if (CBX_droga.Text == "km")
                        {
                            y = float.Parse(TXB1_W3.Text) * 100000;
                        }
                        if (CBX_czas.Text == "h")
                        {
                            z = float.Parse(TXB2_W3.Text) *60;
                        }
                        x = y / z;
                        Wynik_W3.Text = (x).ToString();
                        Wynik_W3.Visibility = Visibility.Visible;
                        break;
                case "mm/ms":
                        if (CBX_droga.Text == "m")
                        {
                            y = float.Parse(TXB1_W3.Text) * 1000;
                        }
                        if (CBX_czas.Text == "s")
                        {
                            z = float.Parse(TXB2_W3.Text)*1000;
                        }
                        if (CBX_droga.Text == "cm")
                        {
                            y = float.Parse(TXB1_W3.Text)*10;
                        }
                        if (CBX_czas.Text == "min")
                        {
                            z = float.Parse(TXB2_W3.Text)*60000;
                        }
                        if (CBX_droga.Text == "mm")
                        {
                            y = float.Parse(TXB1_W3.Text);
                        }
                        if (CBX_czas.Text == "ms")
                        {
                            z = float.Parse(TXB2_W3.Text);
                        }
                        if (CBX_droga.Text == "km")
                        {
                            y = float.Parse(TXB1_W3.Text) * 1000000;
                        }
                        if (CBX_czas.Text == "h")
                        {
                            z = float.Parse(TXB2_W3.Text) *3600000;
                        }
                        x = y / z;
                        Wynik_W3.Text = (x).ToString();
                        Wynik_W3.Visibility = Visibility.Visible;
                        break;
            }
        }
    }
}
