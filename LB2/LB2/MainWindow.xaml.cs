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

namespace LB2
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

        private void BT1_Click(object sender, RoutedEventArgs e)
        {
            Double x = Double.Parse(Input.Text);
            Output.Text = $"{x}";
            int operation1 = CB.SelectedIndex;
            int operation2 = CB2.SelectedIndex;
            Double result = 0;
            switch (operation1)
            {
                case 0:
                    switch (operation2)
                    {
                        case 0:
                            result = x;
                            break;
                        case 1:
                            result = x * 0.3048;
                            break;
                        case 2:
                            result = x * 12;
                            break;
                        case 3:
                            result = x * 30.48;
                            break;
                        case 4:
                            result = x * 0.000189393939;
                            break;

                    }
                    break;
                case 1:
                    switch (operation2)
                    {
                        case 0:
                            result = x* 3.2808399;
                            break;
                        case 1:
                            result = x ;
                            break;
                        case 2:
                            result = x * 39.3700787;
                            break;
                        case 3:
                            result = x * 100;
                            break;
                        case 4:
                            result = x * 0.000621371192;
                            break;

                    }
                    break;
                case 2:
                    switch (operation2)
                    {
                        case 0:
                            result =(Double) x/12;
                            break;
                        case 1:
                            result = x * 0.0254;
                            break;
                        case 2:
                            result = x ;
                            break;
                        case 3:
                            result = x * 2.54;
                            break;
                        case 4:
                            result = x * 1.578*Math.Pow(10,-5);
                            break;

                    }
                    break;
                case 3:
                    switch (operation2)
                    {
                        case 0:
                            result = x* 0.032808399;
                            break;
                        case 1:
                            result = x * 0.01;
                            break;
                        case 2:
                            result = x * 0.393700787;
                            break;
                        case 3:
                            result = x;
                            break;
                        case 4:
                            result = x * 6.2137*Math.Pow(10,-6);
                            break;

                    }
                    break;
                case 4:
                    switch (operation2)
                    {
                        case 0:
                            result = x* 5280;
                            break;
                        case 1:
                            result = x * 1609.344;
                            break;
                        case 2:
                            result = x * 63360;
                            break;
                        case 3:
                            result = x * 160934.4;
                            break;
                        case 4:
                            result = x;
                            break;

                    }
                    break;
            }
            result = Math.Round(result, 2);
            String s1 = CB.Text;
            String s2 = CB2.Text;
            String a = Convert.ToString(x);
            String s = x + " " + s1 + " -> " + s2 + " составляет :";
            LB4.Content = s;
            Output.Text = $"{result}";
        }
    }
}
