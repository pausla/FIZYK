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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Przyspieszenie : Window
    {
        public Przyspieszenie()
        {
            InitializeComponent();
        }

        float x, y, z;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (CBX3.Text)
            {
                case "m/s^2":
                    if (CBX1.Text == "m/s")
                    {
                        x = float.Parse(TBX1.Text);                       
                    }
                    if (CBX1.Text == "cm/min")
                    {
                        x = float.Parse(TBX1.Text)/6000;
                    }
                    if (CBX1.Text == "km/h")
                    {
                        x = (float.Parse(TBX1.Text)*10)/36;
                    }
                    if(CBX2.Text == "s")
                    {
                        y = float.Parse(TBX2.Text);
                    }
                    if (CBX2.Text == "min")
                    {
                        y = float.Parse(TBX2.Text)*60;
                    }
                    if (CBX2.Text == "h")
                    {
                        y = float.Parse(TBX2.Text)*3600;
                    }
                        z = x / y;
                        T_Wynik.Text = (z).ToString();
                        T_Wynik.Visibility = Visibility.Visible;
                        break;
                case "km/s^2":
                        if (CBX1.Text == "m/s")
                        {
                            x = float.Parse(TBX1.Text)/1000;
                        }
                        if (CBX1.Text == "cm/min")
                        {
                            x = float.Parse(TBX1.Text) / 60000;
                        }
                        if (CBX1.Text == "km/h")
                        {
                            x = float.Parse(TBX1.Text)/3600;
                        }
                        if (CBX2.Text == "s")
                        {
                            y = float.Parse(TBX2.Text);
                        }
                        if (CBX2.Text == "min")
                        {
                            y = float.Parse(TBX2.Text) * 60;
                        }
                        if (CBX2.Text == "h")
                        {
                            y = float.Parse(TBX2.Text) * 3600;
                        }
                        z = x / y;
                        T_Wynik.Text = (z).ToString();
                        T_Wynik.Visibility = Visibility.Visible;
                        break;
                case "m/min^2":
                        if (CBX1.Text == "m/s")
                        {
                            x = float.Parse(TBX1.Text)*60;
                        }
                        if (CBX1.Text == "cm/min")
                        {
                            x = float.Parse(TBX1.Text);
                        }
                        if (CBX1.Text == "km/h")
                        {
                            x = (float.Parse(TBX1.Text)*100)/6;
                        }
                        if (CBX2.Text == "s")
                        {
                            y = float.Parse(TBX2.Text)/60;
                        }
                        if (CBX2.Text == "min")
                        {
                            y = float.Parse(TBX2.Text);
                        }
                        if (CBX2.Text == "h")
                        {
                            y = float.Parse(TBX2.Text)*60;
                        }
                        z = x / y;
                        T_Wynik.Text = (z).ToString();
                        T_Wynik.Visibility = Visibility.Visible;
                        break;

            }

        }

    }
}
